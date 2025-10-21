# in-class-activities
## Devlogs
### W1
I moved the cat to the new platform and got it to move by moving the player script and adding it as a component to the cat object. I attached an animation to the cat so that the cat has animation. I changed the movement speed and turn speed of the cat so that the movements make more sense. 

### W2
The r, g, b variables are floats instead of ints, bools, or strings because colors are evaluated with numerical values with decimals. Ints are numerical values but do not include decimals, while bools and strings are not numerical values. 

The _bounce variable is an int instead of other data types because the variable stores the numerical value that corresponds to how much times the ball bounces, which will always be an integer. 

The error message outputted "(file path)(line, column of error) error CS1002: ; expected" which means a semi colon was missing at the following line and column. 

### W3
Table #17
For the parameter of the method, we need the type to be a float since the sanity is represented by 0% - 100%, which can be represented by 2 place decimals. The return type would be void since no data is needed to be returned in order to change the light brightness or the character's sanity level. 

A class can be seen as the earbuds in an airpod. They exists in as themselves, but they also become a component to the charging case of the airpod when attached together. The member variables serve as the internal technical parts that make up the earbud, and the methods determine what happens when you plug the earbud to your ear (auto tries to connect to device with bluetooth activated). 

### W4
Table #17

Line 17 is defining a bool variable _isGrounded with the value of true. 

Line 28 is detecting if the space key is pressed via the Input.GetKeyDown(KeyCode.Space) and whether _isGrounded is true or not. If both conditions are met, then jumping physic is applied to the player and _isGrounded is set to false. 

Line 32 sets the value of the bool variable _isGrounded to false when the condition in line 28 is met. 

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 