import { useEffect, useState } from "react";
import {Bowler} from "./types/bowler"

function BowlerList () {

    // set state
    const [bowler, setBowler] = useState<Bowler[]>([]);

    useEffect(() =>{
    const fetchFood = async () => {
        const response = await fetch ('http://localhost:5114/Bowling');
        const data = await response.json();
        setBowler(data);
    }
    fetchFood();
    }, []);


   

    return(
        <>
            <h1>Bowlers</h1>
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Team Name</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Zip</th>
                        <th>Phone Number</th>
                

                    </tr>
                </thead>
                <tbody>
                    {
                        bowler.map((f) =>(
                            <tr key={f.bowlerID}>
                                <td>{`${f.bowlerFirstName} ${f.bowlerMiddleInit ? f.bowlerMiddleInit + ' ' : ''}${f.bowlerLastName}`}</td>
                                <td>{f.teamID}</td>
                                <td>{f.bowlerAddress}</td>
                                <td>{f.bowlerCity}</td>
                                <td>{f.bowlerState}</td>
                                <td>{f.bowlerZip}</td>
                                <td>{f.bowlerPhoneNumber}</td>
                               

                            </tr>
                              
                        ))
                    }

                </tbody>
            </table>
        </>
    );
}

export default BowlerList