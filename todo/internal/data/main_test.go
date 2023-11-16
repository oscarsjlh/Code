package internal

import (
	"context"
	"log"
	"os"
	"testing"
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
