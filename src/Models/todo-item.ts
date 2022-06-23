export class TodoItem{
    Id?: number;
    Name: string;
    IsComplete?: boolean;

    constructor(Name: string, Id?: number, IsComplete?: boolean) {
        this.Id = Id;
        this.Name = Name
        this.IsComplete = IsComplete
    }
}