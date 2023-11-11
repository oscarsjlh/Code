package main

import (
	"context"
	"net/http"
	"os"

	"github.com/oscarsjlh/todo/internal/data"
)

type application struct {
	todos internal.TodoModel
}

func main() {
	ctx := context.Context(context.Background())
	dsn := os.Getenv("TODO_DB_DSN")
	db, err := internal.NewPool(ctx, dsn)
	if err != nil {
		return
	}
	app := &application{
		todos: &internal.Postgres{DB: db},
	}
	fs := http.FileServer(http.Dir("./static"))
	http.Handle("/static/", http.StripPrefix("/static/", fs))
	http.HandleFunc("/", app.GetTodosHandler)
	http.HandleFunc("/new-todo", app.InsertTodoHandler)
	http.HandleFunc("/delete/", app.RemoveTodoHandler)
	http.HandleFunc("/update/", app.MarkTodoDoneHandler)
	http.HandleFunc("/modify/", app.EditHandlerForm)
	http.HandleFunc("/edit/", app.EditTodoHandler)
	http.ListenAndServe(":3000", nil)
}
