import { useState } from "react";
import { loginUser } from "../services/authService";

import "../styles/loginForm.css";

function LoginForm({ onLogin }) {
  const [userName, setName] = useState("");
  const [password, setPassword] = useState("");
  const [message, setMessage] = useState("");

  const login = async () => {
    try {
      const data = await loginUser(userName, password);

      localStorage.setItem("accessToken", data.accessToken);
      localStorage.setItem("refreshToken", data.refreshToken);

      onLogin();
    } catch (error) {
      setMessage("Login failed ❌ " + error.message);
    }
  };

  return (
    <div className="login-page">
      <div className="login-card">
        <h1>WorkFlowPro</h1>
        <input
          placeholder="Username"
          onChange={(e) => setName(e.target.value)}
        ></input>
        <input
          type="password"
          placeholder="password"
          onChange={(e) => setPassword(e.target.value)}
        ></input>

        <button onClick={login}>Login</button>
        <p>{message}</p>
      </div>
    </div>
  );
}
 

export default LoginForm;
