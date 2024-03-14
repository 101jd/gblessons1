from flask_wtf import FlaskForm
from wtforms import StringField, SubmitField, EmailField, PasswordField
from wtforms.validators import DataRequired


class RegisterForm(FlaskForm):
    name = StringField("Имя: ", validators=[DataRequired()])
    email = EmailField("e-mail: ", validators=[DataRequired()])
    password = PasswordField("Пароль: ", validators=[DataRequired()])
    submit = SubmitField("Отправить")