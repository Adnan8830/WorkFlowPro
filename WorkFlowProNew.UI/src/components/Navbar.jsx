function Navbar({ logout }) {
  return (
    <div className="navbar">
      <h2>WorkFLowPro</h2>
      <button onClick={logout}>Logout</button>
    </div>
  );
}

export default Navbar;
