import axios from "axios";

const API_URL = "https://localhost:7154/api/Auth";

export  const loginUser = async (userName,password) =>{
    const response = await axios.post(
        `${API_URL}/login`,
        {
            userName,
            password
        }
    );

    return response.data;
}



export const logoutUser = async () =>{

    localStorage.removeItem("accessToken");
    localStorage.removeItem("refreshToken");
}