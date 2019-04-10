import React from 'react'
import './auth.css';

export default class CheckIn extends React.Component {
    onEmailChange = (event) => {
        this.props.setEmailText(event.target.value);
    }
    onPasswordChange = (event) => {
        this.props.setPasswordText(event.target.value);
    }
    onButtonClick = (event) => {
        this.props.sendAccount(this.props);
    }

    render() {
        const { email, password } = this.props;
        return (
            <div className="auth-form">
                <form>
                    <h3>Вход</h3>
                    <div className="input">
                        <input
                            type="text"
                            name="login"
                            placeholder="Login"
                            value={email}
                            onChange={this.onEmailChange}
                        />
                    </div>
                    <div className="input">
                        <input
                            type="password"
                            name="password"
                            placeholder="Password"
                            value={password}
                            onChange={this.onPasswordChange}
                        />
                    </div>
                    <button onClick={this.onButtonClick}>Отправить</button>
                </form>
                Мыло: {email}
                <br />
                Пароль: {password}
            </div>
        );
    }
}
