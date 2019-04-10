import React from 'react'
import Auth from './Auth';
import { connect } from 'react-redux';
import { setPasswordText, setEmailText, sendAccount } from '../../store/Auth/actions';

class AuthContainer extends React.Component {
    render() {
        console.log('container');
        return (
            <Auth
                email={this.props.email}
                password={this.props.password}
                setEmailText={this.props.setEmailText}
                setPasswordText={this.props.setPasswordText}
                sendAccount={this.props.sendAccount}
            />
        );
    }
}

const mapStateToProps = (state) => {
    return {
        email: state.auth.email,
        password: state.auth.password
    };
};
const mapDispatchToProps = {
    setEmailText,
    setPasswordText,
    sendAccount
};

export default connect(mapStateToProps, mapDispatchToProps)(AuthContainer); 
