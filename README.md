# Hello .NET

In my new job, I'll be developing a `Backend` with `.NET`. Since I haven't used it before,
I decided to explore this technology before my role begins. Here, you'll find projects and
exercises that are part of my learning path in `.NET` and `C#`.

## Learning Objective

My main goal is to lear how to create and manage a `REST API`. The project at my job uses
a modern `Frontend Framework`, so a `Full-Stack` application isn’t required.

## Repository Structure

All the workshops are in the `workshops/` folder, where each category has its own
subfolder. So a project path will look like this:

- `workshops/<number>-<category>/<project-name>/`

## .NET CLI commands

### Create a new project

- `dotnet new console`: Template for a `CLI`
  - `dotnet new console --use-program-main`: Template for a `CLI` with `Program.Main`
- `dotnet new webapi`: Template for a Minimal `REST API`
  - `dotnet new webapi --use-controllers`: Template for a `REST API` with `Controllers`
- `dotnet new webapp`: Template for a `Full-Stack` Application made with `ASP.NET`

### Run a project

- `dotnet run`: inside the folder of the desired project.
- `dotnet run --project <path>`: to run a project from another folder.

### Build a project

- `dotnet build`: Builds the project in the current folder.

### Add to solution

- `dotnet sln add <path>`: Adds a project to the current solution.

## Contribute

If you notice any mistakes or have suggestions, I’m all ears! I appreciate any feedback so
don't hesitate to [open an Issue on
GitHub](https://github.com/pablocru/hello-dotnet/issues).
