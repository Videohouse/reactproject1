export class PlayerList {
    role: string;
    nr: string; 
    name: string;
    lineupName: string;

    constructor(role: string, nr: string, name: string, lineupName:string) {
        this.role = role;
        this.nr = nr
        this.name = name
        this.lineupName = lineupName
    }
}