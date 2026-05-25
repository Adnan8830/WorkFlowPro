import { useEffect, useState } from "react";

import { getProjects, createProject } from "../services/projectService";
import "../styles/project.css";

function Projects() {
  const [projects, setProjects] = useState([]);
  const [name, setName] = useState("");
  const [description, setDescription] = useState("");


  const loadProjects = async () => {
    const data = await getProjects();
    setProjects(data);
  };

  useEffect(() => {
    loadProjects();
  }, []);


  const handleSubmit = async (e) => {
    e.preventDefault();

    await createProject({ name, description });

    setName("");
    setDescription("");
    loadProjects();
  };

  return (
    <div className="projects-page">
      <div className="projects-header">
        <div>
          <h2>Projects</h2>
          <p className="projects-count">{projects.length} project{projects.length !== 1 ? "s" : ""}</p>
        </div>
      </div>

      <form className="create-project-form" onSubmit={handleSubmit}>
        <p className="create-project-form-title">New Project</p>
        <div className="form-fields">
          <input
            type="text"
            placeholder="Enter Project"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />

          <input
            type="text"
            placeholder="Enter Description"
            value={description}
            onChange={(e) => setDescription(e.target.value)}
          />

          <button>Create</button>
        </div>
      </form>

      {projects.length === 0 ? (
        <div className="projects-empty">
          <div className="projects-empty-icon">
            <svg viewBox="0 0 24 24">
              <rect x="3" y="3" width="18" height="18" rx="3" />
              <path d="M3 9h18M9 21V9" />
            </svg>
          </div>
          <p>No projects yet</p>
          <p className="projects-empty-sub">Create your first project above</p>
        </div>
      ) : (
        <div className="projects-grid">
          {projects.map((p) => (
            <div key={p.id} className="project-card">
              <h3>{p.name}</h3>
              <p>{p.description}</p>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}


export default Projects;
