import React from 'react'
import CheckIn from './CheckIn';
import { connect } from 'react-redux';
import { setPasswordText, setEmailText } from '../../store/Check-In/actions';

class CheckInContainer extends React.Component {
    render() {
        console.log("toProps" + this.props.email);
        return (
            <CheckIn
                email={this.props.email}
                password={this.props.password}
                setEmailText={this.props.setEmailText}
                setPasswordText={this.props.setPasswordText}
            />
        );
    }
}

const mapStateToProps = (state) => {
    console.log(state.email);
    console.log(state.checkIn.email);
    return {
        email: state.checkIn.email,
        password: state.checkIn.password
    };
};
const mapDispatchToProps = {
    setEmailText,
    setPasswordText
};

export default connect(mapStateToProps, mapDispatchToProps)(CheckInContainer); 
