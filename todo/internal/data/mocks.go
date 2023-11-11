package internal

type TodoMock struct {
	InsertTodoFunc func(args string) error
}

func (m *TodoMock) InsertTodo(args string) error {
	return m.InsertTodoFunc(args)
}
