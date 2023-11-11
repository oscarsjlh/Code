package main

import (
	"fmt"
	"html/template"
	"net/http"
	"strconv"
	"strings"
)

func (app *application) GetTodosHandler(w http.ResponseWriter, r *http.Request) {
	todos, err := app.todos.GetTodo()
	if err != nil {
		return
	}
	tmpl := template.Must(template.ParseGlob("templates/*.html"))
	err = tmpl.ExecuteTemplate(w, "index.html", todos)
	if err != nil {
		println("not working")
		return
	}
}

func (app *application) UpdateHomeHandler(w http.ResponseWriter) {
	todos, err := app.todos.GetTodo()
	if err != nil {
		return
	}
	tmpl := template.Must(template.ParseGlob("templates/*.html"))
	w.Header().Set("Content-Type", "text/html; charset=utf-8")
	err = tmpl.ExecuteTemplate(w, "index.html", todos)
	if err != nil {
		return
	}
}

func (app *application) InsertTodoHandler(w http.ResponseWriter, r *http.Request) {
	err := r.ParseForm()
	if err != nil {
		fmt.Printf("Error parsing form", err)
	}

	err = app.todos.InsertTodo(r.FormValue("todo"))
	if err != nil {
		fmt.Println("Could not create todo", err)
	}
	app.UpdateHomeHandler(w)
}

func (app *application) RemoveTodoHandler(w http.ResponseWriter, r *http.Request) {
	idParam := r.URL.Path[len("/delete/"):]
	id, err := strconv.Atoi(idParam)
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
	id, err := strconv.Atoi(idParam)
	print(id)
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
	id, err := strconv.Atoi(idParam)
	if err != nil {
		return
	}
	todo, err := app.todos.SelectTodo(id)
	if err != nil {
		return
	}
	fmt.Printf("%s, %v", todo.Task_name, todo.Id)

	w.Header().Set("Content-Type", "text/html; charset=utf-8")
	editFormTemplate := template.Must(template.ParseFiles("static/edit-form.html"))
	editFormTemplate.Execute(w, todo)
}

func (app *application) EditTodoHandler(w http.ResponseWriter, r *http.Request) {
	err := r.ParseForm()
	if err != nil {
		http.Error(w, "Failed to parse form data", http.StatusBadRequest)
		return
	}
	idParam := r.URL.Path[len("/edit/"):]
	id, err := strconv.Atoi(idParam)
	println(id)
	task := r.Form.Get("task")
	println(task)
	err = app.todos.EditTodo(id, task)
	if err != nil {
		return
	}
	app.UpdateHomeHandler(w)
}
