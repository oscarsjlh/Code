package main

import (
	"fmt"
	"log"
	"net/http"
	"strings"

	internal "github.com/oscarsjlh/todo/internal/data"
)

// TodoData is the data passed to the template
// improve GetTodosHandler
func (app *application) GetTodosHandler(w http.ResponseWriter, r *http.Request) {
	todos, err := app.todos.GetTodo()
	if err != nil {
		log.Printf("failed to connect to db %v", err)
		http.Error(w, "Internal Server Error", http.StatusInternalServerError)
		return
	}
	data := TodoData{
		Todos: todos,
	}
	println(todos)
	err = renderTemplate(w, "index.html", data)
	if err != nil {
		log.Printf("failed to render tmp %v", err)
		http.Error(w, "Internal Server Error", http.StatusInternalServerError)
		return
	}
}

func (app *application) UpdateHomeHandler(w http.ResponseWriter) {
	todos, err := app.todos.GetTodo()
	if err != nil {
		log.Fatal("failed to updateHome while getting todos")
	}
	data := TodoData{
		Todos: todos,
	}
	err = renderTemplate(w, "index.html", data)
	if err != nil {
		log.Fatal("failed to updateHome while rendering template")
	}
}

func (app *application) InsertTodoHandler(w http.ResponseWriter, r *http.Request) {
	err := r.ParseForm()
	if err != nil {
		fmt.Printf("Error parsing form %v", err)
	}

	err = app.todos.InsertTodo(r.FormValue("todo"))
	if err != nil {
		fmt.Println("Could not create todo", err)
	}
	app.UpdateHomeHandler(w)
}

func (app *application) RemoveTodoHandler(w http.ResponseWriter, r *http.Request) {
	idParam := r.URL.Path[len("/delete/"):]
	id, err := validateIDParam(w, idParam)
	if err != nil {
		http.Error(w, "Invalid  or missing 'id' parameter", http.StatusBadRequest)
		return
	}

	err = app.todos.RemoveTodo(id)
	if err != nil {
		return
	}

	app.UpdateHomeHandler(w)
}

func (app *application) MarkTodoDoneHandler(w http.ResponseWriter, r *http.Request) {
	idParam := r.URL.Path[len("/update/"):]
	id, err := validateIDParam(w, idParam)
	if err != nil {
		http.Error(w, "Invalid  or missing 'id' parameter", http.StatusBadRequest)
		return
	}
	err = app.todos.MarkTodoAsDone(id)
	if err != nil {
		println("failed to update db")
		return
	}
	app.UpdateHomeHandler(w)
}

func (app *application) EditHandlerForm(w http.ResponseWriter, r *http.Request) {
	pathParts := strings.Split(r.URL.Path, "/")
	idParam := pathParts[len(pathParts)-1]
	id, err := validateIDParam(w, idParam)
	if err != nil {
		return
	}
	todo, err := app.todos.SelectTodo(id)
	if err != nil {
		return
	}
	data := TodoData{
		Todos: []internal.Todo{*todo},
	}

	w.Header().Set("Content-Type", "text/html; charset=utf-8")
	err = renderTemplate(w, "edit-form.html", data)
	if err != nil {
		log.Printf("failed to render tmp %v", err)
		http.Error(w, "Internal Server Error", http.StatusInternalServerError)
		return
	}
}

func (app *application) EditTodoHandler(w http.ResponseWriter, r *http.Request) {
	err := r.ParseForm()
	if err != nil {
		http.Error(w, "Failed to parse form data", http.StatusBadRequest)
		return
	}
	idParam := r.URL.Path[len("/edit/"):]
	id, err := validateIDParam(w, idParam)
	task := r.Form.Get("task")
	println(task)
	err = app.todos.EditTodo(id, task)
	if err != nil {
		return
	}
	app.UpdateHomeHandler(w)
}
