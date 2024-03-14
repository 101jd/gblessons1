from flask import Flask, render_template
from regForm import RegisterForm

app = Flask(__name__)
app.config['SECRET_KEY'] = "hello hello" #anti-CSRF


@app.route("/register", methods=["GET", "POST"])
def register():
    form = RegisterForm()
    if form.validate_on_submit():
        print(form.data['name'],
              form.data['email'],
              form.data['password'])
    return render_template("reg.html", form=form)


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