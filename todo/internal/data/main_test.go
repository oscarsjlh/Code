package internal

import (
	"context"
	"log"
	"os"
	"testing"

	"github.com/golang-migrate/migrate/v4"
	_ "github.com/golang-migrate/migrate/v4/database/postgres"
	_ "github.com/golang-migrate/migrate/v4/source/file"
)

var dsn = os.Getenv("TODO_DB_DSN")

func main() {
	dsn := os.Getenv("TODO_DB_DSN")
	m, err := migrate.New(
		"file://migrate_tests",
		dsn,
	)
	if err != nil {
		log.Fatal(err)
	}
	if err := m.Up(); err != nil {
		log.Fatal(err)
	}
}

func (app *TodoModel) TestInsertTodo(t *testing.T) {
	mock := &TodoMock{
		InsertTodoFunc: func(args string) error {
			return nil
		},
	}
	ctx := context.Context(context.Background())
	db, err := NewPool(ctx, dsn)
	if err != nil {
		return
	}
	pg := &Postgres{
		DB: NewPool(db),
	}
}
