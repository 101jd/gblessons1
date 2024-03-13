from flask import Flask, render_template


app = Flask(__name__)


@app.route("/") # GET
def index():
    return render_template('base.html')

@app.route("/calc/<int:x>/<int:y>")
def sum(x, y):
    return f'{x} + {y} = {x + y}<br>{x} - {y} = {x - y}<br>{x} * {y} = {x * y}<br>{x} / {y} = {x / y}<br><a href="/">Главная</a>'


@app.route("/list")
def list_students():
    data = ["Екатерина Конькова", "Азер Агазаде",
            "Святослав Мариничев", "Ольга Шенкель",
            "Алексей Красько", "Дмитрий Захаров",
            "Всеволод Харламенко", "Сергей Силькунов"]
    return render_template("list.html", data = data,
                           title = "Список студентов")
if __name__ == '__main__':
    app.run()