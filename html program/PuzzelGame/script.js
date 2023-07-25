class Box{
    constructor(x,y)
    {
        this.x=x;
        this.y=y;
    }

    getTopBox(){

    }
    
}

class state{
   constructor(grid,move,time,status){
    this.grid=grid;
    this.move=move;
    this.time=time;
    this.status=status;
   }

   static ready(){
    return new state(
        [[0,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,0,0]],
        0,
        0,
        "ready"
    )
   }

   static start(){
    return new state(getRandomGrid(),0,0,"playing")};
}