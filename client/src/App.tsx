import { FC, useState, useEffect } from 'react';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

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
      <Header as='h2' icon='users' content='Churtivities' />
      <List>
        {activities?.map((activity: any, idx) => {
          return (
            <List.Item key={activity.id}>{activity.title}</List.Item>
          );
        })}
      </List>
    </div>
  );
};

export default App;
