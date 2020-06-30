Example Title:           Custom Digital States
                         
Example Filename:        CustomDigitalStates.sln
                         
Category:                User Interface - Digital Waveform Graph
                         
Description:             This example demonstrates the extensibility features of the Digital Waveform Graph.
			 The radio buttons in each group box can be used to ser the specified feature to 
			 its default value or a custom value. The custom waveform state style shades the
			 waveform states with the diagonal brick fill style. This is done by creating a			 		 			         class that derives from DigitalWaveformStateStyle and override the DrawState 
			 function. 
			 The custom signal state style displays the label in a custom format.
			 This is done by creating a class that derives from DigitalSignalStateStyle and
			 overrides the DrawLabelFormat and DrawState function.
                                       
Software Group:          Measurement Studio                          
                         
Required Software:       
                         
Language:                Visual Basic .NET, Visual C#
                         
Language Version:        8.0
                         
Hardware Group:          
                         
Driver Name:             
                         
Driver Version:          
                         
Required Hardware:       