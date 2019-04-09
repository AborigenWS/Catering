import React from 'react'
import './checkin.css';

export default class CheckIn extends React.Component {
    constructor(props) {
        super(props);
        this.onEmailChange = this.onEmailChange.bind(this);
        this.onPasswordChange = this.onPasswordChange.bind(this);
    }

    onEmailChange(event) {
        this.props.setEmailText(event.target.value);
    }
    onPasswordChange(event) {
        this.props.setPasswordText(event.target.value);
    }

    render() {
        const { email, password } = this.props;
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
                </form>
                email: {email}
                <br />
                password: {password}
            </div>
        );
    }
}
