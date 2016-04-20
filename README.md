# TextAndPizza
TextAndPizza
Here are some guides for some tasks:

## Adding Pictures ##
1. Make your picture, don't copy any from the internet, because that is bad like they taught us in RP!
2. Put your image in the Resources folder.
3. Well... That's about it.

## Adding Rooms ##
<b>NOTE: If you don't quite understand, contact Jarod as you could break things if you do it wrong.</b>
<br />
1. Go into the Form1.cs Class (Class means File)
2. Start at the top and start scrolling slowly, until you see a massive list of variables (Things like int and Boolean and Room). You should see a list of things like "Room RoomName;" where RoomName is different.
3. After the last Room listed, make a new line and write "Room roomName;" Without quotes. roomName can be anything you like, it's best to just call the room what it is meant to be, then add a 1 after. So if you are making a pizza shop, call it PizzaShop1. Use no spaces and make the first letter of each word capital. Also, at the end of "Room PizzaShop1;" DO NOT FORGET the semi-colon, which is this ";"
4. After you have done that, scroll down to where you see: <br />
  public void MapRooms() <br />
  { <br />
  	//Stuff in here <br />
  }
5. Below the line that says "//Declare Rooms" add a line that says "//Room" and where it says Room, put the name of the room you want to make, in the example above, this would be //PizzaShop1. This is just a comment so other people reading your code can see where the code for your room begins.
6. Write this code: <br />
PizzaShop1 = new Room();
7. Inside the brackets, write: <br />
"Pizza Shop", <br />
"a nice warm pizza shop that smells like garlic" <br />
so it should become: <br />
PizzaShop1 = new Room("Pizza Shop", <br />
	"a nice warm pizza shop that smells like garlic" <br />
);
8. Congratulations! You just made a room!
