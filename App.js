import logo from './logo.svg';
import './App.css';
import axios from "axios";

function App() {
    const getAllUsers = async () => {
        const res = await axios.get('https://localhost:7142/User/users');
        console.log("Hello:", res.data)
    };
    const getUserById = async () => {
        const res = await axios.get('https://localhost:7142/User/users/get?id=101');
        console.log(" res:", res.data);
    };
    const AddUser = async () => {
        const res = await axios.post('https://localhost:7142/User/users/add', { Id: 101, phone: 8289});
        console.log(res.data);
    };
    const DeleteUser = async () => {
        const res = await axios.delete('https://localhost:7142/User/users/delete?id=5');
        console.log("res:", res.data);
    };
    const UpdateUser = async () => {
        const res = await axios.put('https://localhost:7142/User/users/update?id=11');
        console.log("res:", res.data);

    };
    return (
        <div className='MyApp' style={{ textAlign: 'center', marginTop: '15px' }}>
            <h2>User Dashboard</h2>
            <div style={{ textAlign: 'center', marginTop: '15px' }}>
                <button type="button" style={{ backgroundColor: 'black', color: 'white', fontsize: '15px', borderRadius: '5px' }} onClick={getAllUsers} >Get All users</button>
                <button type="button" style={{ backgroundColor: 'black', color: 'white', fontsize: '15px', borderRadius: '5px' }} onClick={getUserById} >Get User By Id</button>
                <button type="button" style={{ backgroundColor: 'black', color: 'white', fontsize: '15px', borderRadius: '5px' }} onClick={AddUser} >Add user</button>
                <button type="button" style={{ backgroundColor: 'black', color: 'white', fontsize: '15px', borderRadius: '5px' }} onClick={DeleteUser} >Delete User</button>
                <button type="button" style={{ backgroundColor: 'black', color: 'white', fontsize: '15px', borderRadius: '5px' }} onClick={UpdateUser} >Update User</button>
            </div>

        </div>

    );
}
export default App;