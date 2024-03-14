import { useEffect, useState } from 'react';
import { Bowlers } from '../types/Bowlers';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowlers[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const bowlerResponse = await fetch('http://localhost:5143/Bowler');
      const teamResponse = await fetch('http://localhost:5143/Team');

      const bowlerData = await bowlerResponse.json();
      const teamData = await teamResponse.json();

      const bowlerWithTeamData = bowlerData.map((bowler: { teamID: any }) => {
        const team = teamData.find(
          (team: { teamID: any }) => team.teamID === bowler.teamID,
        );
        return {
          ...bowler,
          teamName: team ? team.teamName : 'Unknown Team',
        };
      });

      setBowlerData(bowlerWithTeamData);
    };

    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData
            .filter((b) => b.teamName === 'Marlins' || b.teamName === 'Sharks')
            .map((b) => (
              <tr key={b.bowlerID}>
                <td>
                  {b.bowlerFirstName +
                    (b.bowlerMiddleInit ? ' ' + b.bowlerMiddleInit + '.' : '') +
                    ' ' +
                    b.bowlerLastName}
                </td>
                <td>{b.teamName}</td>
                <td>{b.bowlerAddress}</td>
                <td>{b.bowlerCity}</td>
                <td>{b.bowlerState}</td>
                <td>{b.bowlerZip}</td>
                <td>{b.bowlerPhoneNumber}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
