package main

import (
	"net/http"
)

func (app *application) healthcheckHandler(w http.ResponseWriter, r *http.Request) {
	env := envelope{
		"status": "avalible",
		"system_info": map[string]string{
			"enviroment": app.config.env,
			"version":    version,
		},
	}
	err := app.writeJson(w, http.StatusOK, env, nil)
	if err != nil {
		app.serverErrorResponse(w, r, err)
	}
}
