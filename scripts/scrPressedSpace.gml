if(state == "idle")
{
var inst = instance_nearest(x,y,mailBoxBlue_obj);
if(inst != noone && inst.state == "readyForPickUp" && inst.Lane == currentLane)
{
inst.x = x;
inst.y = y - 100;
inst.state = "PickedUp";
state = "pickedUp";
return 0;

}
inst = instance_nearest(x,y,mailBoxRed_Obj)
if(inst != noone && inst.state == "readyForPickUp" && inst.Lane == currentLane )
{
inst.x = x ;
inst.y = y - 100;
inst.state = "PickedUp";
state = "pickedUp";
return 0;
}

inst = instance_nearest(x,y,mailBoxGreen_obj)
if(inst != noone && inst.state == "readyForPickUp" && inst.Lane == currentLane)
{
inst.x = x;
inst.y = y - 100 ;
inst.state = "PickedUp";
state = "pickedUp";
return 0;
}
}
else if(state == "pickedUp")
{

var inst = instance_nearest(x,y,mailBoxBlue_obj)
if(inst != noone && inst.state == "PickedUp")
{
inst.state = "dropped";
state = "idle";
return 0;
}
inst = instance_nearest(x,y,mailBoxRed_Obj)
if(inst != noone && inst.state == "PickedUp")
{
inst.state = "dropped";
state = "idle";
return 0;
}
inst = instance_nearest(x,y,mailBoxGreen_obj)
if(inst != noone && inst.state == "PickedUp")
{
inst.state = "dropped";
state = "idle";
return 0;
}

}
