import axiosInstance from "../api/axiosInstance";

export  const loginUser = async (userName,password) =>{
    const response = await axiosInstance.post(
        `/Auth/login`,
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