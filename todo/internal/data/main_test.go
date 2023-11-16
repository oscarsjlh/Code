package internal

import (
	"context"
	"log"
	"os"
	"testing"
)

var dsn = os.Getenv("TODO_DB_DSN")

func main(t *testing.T) {
	dsn := os.Getenv("TODO_DB_DSN")
	m, err := migrate.New(
		"file://migrate_tests",
		dsn,
	)
	if err != nil {
		log.Fatal(err)
	}
	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			pg, err := setupTest()
			if err != nil {
				t.Fatalf("Failed to setup testdb conn: %v", err)
			}
			defer teardownTest(pg)
			tt.test(t, pg)
		})
	}
}

func setupTest() (*Postgres, error) {
	ctx := context.Background()
	db, err := NewPool(ctx, dsn)
	if err != nil {
		log.Fatal("Failed to connect to db")
		return nil, err
	}
	pg := &Postgres{
		DB: db,
	}
	return pg, nil
}

func teardownTest(pg *Postgres) {
	pg.Close()
}

func TestInsertTodo(t *testing.T) {
	pg, err := setupTest()
	if err != nil {
		t.Fatalf("Failed to setup test: %v", err)
	}
	defer teardownTest(pg)

	args := "Test Todo"
	err = pg.InsertTodo(args)
	if err != nil {
		t.Errorf("InsertTodo failed: %v", err)
	}
	lastTodo, err := pg.GetLastInsertedTodo()
	if err != nil {
		t.Errorf("Error getting last inserted todo: %v", err)
	}
	if lastTodo.Task_name != args {
		t.Errorf("Expected todo task_name %s, got: %s", args, lastTodo.Task_name)
	}
	if lastTodo.Status != false {
		t.Errorf("Expected todo status false, got: %t", lastTodo.Status)
	}
}

func TestGetTodo(t *testing.T) {
	pg, err := setupTest()
	if err != nil {
		t.Fatalf("Failed to setup test: %v", err)
	}
	defer teardownTest(pg)
	args := "Test Todo"
	err = pg.InsertTodo(args)
	if err != nil {
		t.Errorf("InsertTodo failed: %v", err)
	}

	todos, err := pg.GetTodo()
	if err != nil {
		t.Errorf("Get todo failed: %v", err)
	}
	tlenght := len(todos)
	if tlenght < 1 {
		println(tlenght)
		t.Errorf("Get todo lenght should be atleast 1: %v", err)
	}
}

func TestDeleteTodo(t *testing.T) {
	pg, err := setupTest()
	if err != nil {
		t.Fatalf("Failed to setup test: %v", err)
	}
	defer teardownTest(pg)
	args1 := "TestTodo1"
	err = pg.InsertTodo(args1)
	if err != nil {
		t.Errorf("InsertTodo failed: %v", err)
	}
	err = pg.RemoveTodo(1)
	if err != nil {
		t.Errorf("RemoveTodofailed: %v", err)
	}
	_, err = pg.SelectTodo(1)
	if err == nil {
		t.Error("Expected error has todo should have been removed")
	}
}

func TestMarkTodoAsDone(t *testing.T) {
	pg, err := setupTest()
	if err != nil {
		t.Fatalf("Failed to setup test: %v", err)
	}
	defer teardownTest(pg)
	args1 := "TestTodo1"
	err = pg.InsertTodo(args1)
	if err != nil {
		t.Errorf("InsertTodo failed: %v", err)
	}
	lastTodo, err := pg.GetLastInsertedTodo()
	if err != nil {
		t.Errorf("Error getting last inserted todo: %v", err)
	}
	err = pg.MarkTodoAsDone(lastTodo.Id)
	if err != nil {
		t.Errorf("MarkTodo as done failed: %v", err)
	}

	todo, err := pg.SelectTodo(lastTodo.Id)
	if todo.Status != true {
		t.Errorf("Expected todo status to be true: %v", err)
	}
}

func TestEditTodo(t *testing.T) {
	pg, err := setupTest()
	if err != nil {
		t.Fatalf("Failed to setup test: %v", err)
	}
	defer teardownTest(pg)
	args1 := "Testing todoapp"
	err = pg.InsertTodo(args1)
	if err != nil {
		t.Errorf("InsertTodo failed: %v", err)
	}
	lastTodo, err := pg.GetLastInsertedTodo()
	if err != nil {
		t.Errorf("Error getting last inserted todo: %v", err)
	}
	editedArg := "Edited todo"
	pg.EditTodo(lastTodo.Id, editedArg)

	editedtodo, err := pg.SelectTodo(lastTodo.Id)
	if err != nil {
		t.Errorf("Error getting last inserted todo: %v", err)
	}
	if editedtodo.Task_name != editedArg {
		t.Errorf("Editing todo failed testing: %v", err)
	}
}
