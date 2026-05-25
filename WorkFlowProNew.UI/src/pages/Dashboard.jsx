import Navbar from "../components/Navbar";
import Projects from "../pages/Projects";
import "../styles/dashboard.css";

function Dashboard({logout}){
    return(
        <div className="app-layout">
            <Navbar logout={logout}/>
            <Projects/>
        </div>
    );
}

export default Dashboard;