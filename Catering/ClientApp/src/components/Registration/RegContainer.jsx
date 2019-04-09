import React from 'react'
import Registration from './Registration';
import { connect } from 'react-redux';
import { setPasswordText, setEmailText, setRepeatPasswordText } from '../../store/Registration/actions';

class RegContainer extends React.Component {
    render() {
        return (
            <Registration
                email={this.props.email}
                password={this.props.password}
                repeatPassword={this.props.repeatPassword}
                setEmailText={this.props.setEmailText}
                setPasswordText={this.props.setPasswordText}
                setRepeatPasswordText={this.props.setRepeatPasswordText}
            />
        );
    }
}

const mapStateToProps = (state) => {
    return {
        email: state.reg.email,
        password: state.reg.password,
        repeatPassword: state.reg.repeatPassword
    };
};
const mapDispatchToProps = {
    setEmailText,
    setPasswordText,
    setRepeatPasswordText
};

export default connect(mapStateToProps, mapDispatchToProps)(RegContainer); 
