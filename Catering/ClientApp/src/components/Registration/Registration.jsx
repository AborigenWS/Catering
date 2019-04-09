import React from 'react'
import './reg.css';

export default class Registration extends React.Component {
    onEmailChange = (event) => {
        this.props.setEmailText(event.target.value);
    }
    onPasswordChange = (event) => {
        this.props.setPasswordText(event.target.value);
    }
    onRepeatPasswordChange = (event) => {
        this.props.setRepeatPasswordText(event.target.value);
    }

    render() {
        const { email, password, repeatPassword } = this.props;
        return (
            <div>
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
                    <div className="input">
                        <input
                            type="password"
                            name="repeatPassword"
                            placeholder="Repeat Password"
                            value={repeatPassword}
                            onChange={this.onRepeatPasswordChange}
                        />
                    </div>
                </form>
                email: {email}
                <br />
                password: {password}
                <br />
                repeat password: {repeatPassword}
            </div>
        );
    }
}
