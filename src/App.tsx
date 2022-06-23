import React, { useEffect } from 'react';
import logo from './logo.svg';
import './App.css';
import { TodoItem } from './Models/todo-item';

function App() {

    useEffect(() => {
        /*
        const requestOptions = {
            method: "POST",
            headers: { "Content-Type":"application/ json" },
            body: JSON.stringify({"Name":"walk dog","IsComplete":true})
        }
        fetch("api/TodoItems", requestOptions).then(response => response.json()).then(data => console.log(data))
        */
        fetch("api/playerlist/Antwerp2").then(response => response.json()).then(data => console.log(data))
    },[])
   
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
