PROJECT_NAME=PublicApi

all: build run

build:
	dotnet build

run:
	dotnet run --project $(PROJECT_NAME)

watch:
	dotnet watch run --project $(PROJECT_NAME)

test:
	dotnet test $(PROJECT_NAME).Tests/$(PROJECT_NAME).Tests.csproj

clean:
	dotnet clean $(PROJECT_NAME)

.PHONY: all build run watch test clean
