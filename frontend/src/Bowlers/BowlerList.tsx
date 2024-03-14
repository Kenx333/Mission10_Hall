import { useEffect, useState } from 'react';
import { Bowlers } from '../types/Bowlers';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowlers[]>([]);
  //useeffect so it doesn't continually run
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:44314/bowlers'); //fetching the json file from .NET app
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);

  // return statement that returns the actual table
  return (
    <>
      <div className="row">
        <h1>Bowler Data</h1>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler ID</th>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team</th>
            <th>Street</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => (
            <tr>
              <td>{f.bowlerId}</td>
              <td>{f.bowlerFirstName}</td>
              <td>{f.bowlerMiddleInit}</td>
              <td>{f.bowlerLastName}</td>
              <td>{f.teamName}</td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
