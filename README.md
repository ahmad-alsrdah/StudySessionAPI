# Study Session API 🪢

Study Session API is a RESTful Web API built with ASP.NET Core.
It allows users to manage study sessions by creating, updating, retrieving, and deleting sessions.

The API demonstrates core backend concepts such as:
- RESTful API design
- CRUD operations
- JSON Patch for partial updates
- Model validation
- Swagger API documentation

---
## Technologies 🛠️

- ASP.NET Core Web API
- C#
- .NET
- REST API
- Swagger (OpenAPI)
- JSON Patch

---
## Features 🪄

- Create study sessions
- Retrieve all sessions
- Update sessions (PUT)
- Partially update sessions (PATCH)
- Delete sessions
- Input validation using ModelState
- Interactive API documentation with Swagger

---
## How to Run 🏃‍♂️‍➡️

1. Clone the repository:
```
git clone https://github.com/ahmad-alsrdah/StudySessionAPI.git
```
2. Open the project in VS Code (or any IDE)
3. In Terminal:
```
dotnet run 
```
--- 
## Example PATCH Request 🔑

```
[
    {"op":"replace","path","/FocusLevel","value":5}
]
```
---
## Future Improvements ⏳

- Add SQL Server database
- Implement authentication using JWT
- Add unit tests
- Improve logging
---
## Contact 🔎

Feel free to connect with me or reach out if you have any feedback or collaboration ideas.
- LinkedIn: [Ahmad Al-Srdah](https://www.linkedin.com/in/ahmad-al-srdah-2a4b87325/)
- GitHub: [ahmad-alsrdah](https://github.com/ahmad-alsrdah)
- Email: ahmad2315753@gmail.com
