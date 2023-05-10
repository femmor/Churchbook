import { FC, useState, useEffect } from 'react';
import './App.css';
import axios from 'axios';

export interface AppProps {}

const App: FC<AppProps> = () => {
  const [activities, setActivities] = useState([]);

  const fetchActivities = async () => {
    await axios
      .get('http://localhost:5000/api/activities')
      .then((response) => {
        setActivities(response.data);
        console.log(activities);
      });
  };

  useEffect(() => {
    fetchActivities();
  }, []);

  return (
    <div className='App'>
      <h1>React App</h1>
      <ul>
        {activities?.map((activity: any, idx) => {
          return <li key={activity.id}>{activity.title}</li>;
        })}
      </ul>
    </div>
  );
};

export default App;
