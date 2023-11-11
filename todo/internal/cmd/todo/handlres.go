package handlers

import (
	"context"
	"fmt"
	"html/template"
	"log"
	"net/http"
	"os"
	"strconv"
	"strings"

	internal "github.com/oscarsjlh/todo/internal/data"
)

func (app *application) GetTodosHandler(w http.ResponseWriter, r *http.Request) {
	todos, err := pg.GetTodo()
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

func UpdateHomeHandler(w http.ResponseWriter) {
	conn, err := internal.ConnectDB()
	if err != nil {
		return
	}

	todos, err := internal.GetTodo(conn)
	if err != nil {
		return
	}
	tmpl := template.Must(template.ParseFiles("static/index.html"))
	w.Header().Set("Content-Type", "text/html; charset=utf-8")
	err = tmpl.ExecuteTemplate(w, "table.html", todos)
	if err != nil {
		return
	}
}

func InsertTodoHandler(w http.ResponseWriter, r *http.Request) {
	err := r.ParseForm()
	if err != nil {
		fmt.Printf("Error parsing form", err)
	}
	conn, err := internal.ConnectDB()
	if err != nil {
		return
	}
	err = internal.InsertTodo(conn, r.FormValue("todo"))
	if err != nil {
		fmt.Println("Could not create todo", err)
	}
	UpdateHomeHandler(w)
}

func RemoveTodoHandler(w http.ResponseWriter, r *http.Request) {
	idParam := r.URL.Path[len("/delete/"):]
	id, err := strconv.Atoi(idParam)
	if err != nil {
		http.Error(w, "Invalid  or missing 'id' parameter", http.StatusBadRequest)
		return
	}
	conn, err := internal.ConnectDB()
	if err != nil {
		http.Error(w, "Error connecting to db", http.StatusInternalServerError)
		return
	}
	err = internal.RemoveTodo(conn, id)
	if err != nil {
		return
	}
}

func MarkTodoDoneHandler(w http.ResponseWriter, r *http.Request) {
	idParam := r.URL.Path[len("/update/"):]
	id, err := strconv.Atoi(idParam)
	print(id)
	if err != nil {
		http.Error(w, "Invalid  or missing 'id' parameter", http.StatusBadRequest)
		return
	}
	conn, err := internal.ConnectDB()
	if err != nil {
		http.Error(w, "Error connecting to db", http.StatusInternalServerError)
		return
	}
	err = internal.MarkTodoAsDone(conn, id)
	if err != nil {
		println("failed to update db")
		return
	}
	UpdateHomeHandler(w)
}

func EditHandlerForm(w http.ResponseWriter, r *http.Request) {
	pathParts := strings.Split(r.URL.Path, "/")
	println(pathParts)
	idParam := pathParts[len(pathParts)-1]
	id, err := strconv.Atoi(idParam)
	if err != nil {
		return
	}
	println(id)
	conn, err := internal.ConnectDB()
	if err != nil {
		return
	}
	todo, err := internal.SelectTodo(conn, id)
	if err != nil {
		return
	}
	fmt.Printf("%s, %v", todo.Task_name, todo.Id)

	w.Header().Set("Content-Type", "text/html; charset=utf-8")
	editFormTemplate := template.Must(template.ParseFiles("static/edit-form.html"))
	editFormTemplate.Execute(w, todo)
}

func EditTodoHandler(w http.ResponseWriter, r *http.Request) {
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
	conn, err := internal.ConnectDB()
	if err != nil {
		http.Error(w, "Error connecting to db", http.StatusInternalServerError)
		return
	}
	err = internal.EditTodo(conn, id, task)
	if err != nil {
		return
	}
	UpdateHomeHandler(w)
}
