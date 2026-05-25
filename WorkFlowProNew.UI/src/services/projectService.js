import axiosInstance from "../api/axiosInstance";

export const getProjects = async () => {
  const response = await axiosInstance.get("/project");
  return response.data;
};

export const createProject = async (project) => {
  const response = await axiosInstance.post("/project", project);
  return response.data;
};
