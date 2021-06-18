# RoboticSpider

Project in .net core 5.

Run project: http://localhost:5000

Postman:

GET: http://localhost:5000/api/spider/move

Header: Content-Type, application/json

Body:

{
    "maxX": 7,
    "maxY": 15,
    "currX": 4,
    "currY": 10,
    "commands": [
        "F",
        "L",
        "F",
        "L",
        "F",
        "R",
        "F",
        "F",
        "L",
        "F"
    ],
    "direction": "Left"
}
