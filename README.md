# Unity 2D Water Shader

Add a nice refraction water shader to your game!

Checkout the video:

[![Youtube Demo Video](https://img.youtube.com/vi/M-sK7hOlYnE/1.jpg)](https://www.youtube.com/watch?v=M-sK7hOlYnE)


## Usage

### Try it 

Just clone or download the repository and open the folder within Unity. 

Run the included Demo Scene.


### Use it within your Game


* Put the DisplacementBehaviour and DisplacementShader into your game. Keep the shader under Resources folder.

* Attach the DisplacementBehaviour to your main camera and set up a noise and water texture as behaviour property (the sample ships with sample textures).

* Limit the water effect to a certain scene area by adding planes to the built-in Water layer.

* You can specify the turbulence (waviness) of the water by setting the Turbulence property of the DisplacementBehaviour. The turbulence will also influence the strength of refraction.


### Implement Scrolling

When the camera scrolls left or right, the water waves need to change their phase offset. Otherwise they will appear to be a "camera overlay" flying over the scene.

The DisplacementBehaviour has a scroll offset parameter which can be incremented / decremented on scrolling.

Check out the included CamScrollBehaviour as a reference implementation for scrolling.



## What's next

* Physical Collision Behaviour (Ripples)

* Better Effects (I'm experimenting ;) )

* Better Demo Scene


## Disclaimer

I am pretty new to shader programming, so the source may not be optimal. Contributions are welcome! :)
I tested the shader on Windows, Mac OS, iPad Pro 9.7 and iPhone 7.


## Implementation

I am currently writing a tutorial about the details. Stay tuned :)


## Contact

Feel free to contact me if you have any questions. In case you are going to use this shader within some application, I'd be happy to hear about :)

Follow me on Twitter: 
[twitter.com/mbue_coding](https://twitter.com/mbue_coding)
