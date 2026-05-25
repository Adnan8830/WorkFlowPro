import {useState} from "react";
import Dashboard from "./pages/Dashboard";
import LoginForm from "./components/LoginForm";
import {logoutUser} from "./services/authService";

function App(){

  const [loggedIn,setLoggedIn] = useState(!!localStorage.getItem("accessToken"));


  const logout = ()=>{
    logoutUser();
    setLoggedIn(false);

  };

  return loggedIn ? <Dashboard logout={logout} /> : <LoginForm onLogin={() => setLoggedIn(true)} />;
}


export default App;