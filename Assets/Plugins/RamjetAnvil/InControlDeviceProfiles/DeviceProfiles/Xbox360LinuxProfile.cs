using System;


namespace InControl
{
	// @cond nodoc
	[AutoDiscover]
	public class Xbox360LinuxProfile : UnityInputDeviceProfile
	{
		public Xbox360LinuxProfile()
		{
			Name = "XBox 360 Controller";
			Meta = "XBox 360 Controller on Linux";

			SupportedPlatforms = new[] {
				"Linux"
			};

			JoystickNames = new[] {
				"Microsoft X-Box 360 pad",
				"Generic X-Box pad"
			};

			LastResortRegex = "360";

			MaxUnityVersion = new VersionInfo( 4, 9 );

			ButtonMappings = new[] {
				new InputControlMapping {
					Handle = "A",
					Target = InputControlTarget.Action1,
					Source = Button0
				},
				new InputControlMapping {
					Handle = "B",
					Target = InputControlTarget.Action2,
					Source = Button1
				},
				new InputControlMapping {
					Handle = "X",
					Target = InputControlTarget.Action3,
					Source = Button2
				},
				new InputControlMapping {
					Handle = "Y",
					Target = InputControlTarget.Action4,
					Source = Button3
				},
				new InputControlMapping {
					Handle = "Left Bumper",
					Target = InputControlTarget.LeftBumper,
					Source = Button4
				},
				new InputControlMapping {
					Handle = "Right Bumper",
					Target = InputControlTarget.RightBumper,
					Source = Button5
				},
				new InputControlMapping {
					Handle = "Left Stick Button",
					Target = InputControlTarget.LeftStickButton,
					Source = Button9
				},
				new InputControlMapping {
					Handle = "Right Stick Button",
					Target = InputControlTarget.RightStickButton,
					Source = Button10
				},
				new InputControlMapping {
					Handle = "DPad Left",
					Target = InputControlTarget.DPadLeft,
					Source = Button11,
					Invert = true
				},
				new InputControlMapping {
					Handle = "DPad Right",
					Target = InputControlTarget.DPadRight,
					Source = Button12,
				},
				new InputControlMapping {
					Handle = "DPad Up",
					Target = InputControlTarget.DPadUp,
					Source = Button13,
					Invert = true
				},
				new InputControlMapping {
					Handle = "DPad Down",
					Target = InputControlTarget.DPadDown,
					Source = Button14,
				},
				new InputControlMapping {
					Handle = "Back",
					Target = InputControlTarget.Back,
					Source = Button6
				},
				new InputControlMapping {
					Handle = "Start",
					Target = InputControlTarget.Start,
					Source = Button7
				},
				new InputControlMapping {
					Handle = "Menu",
					Target = InputControlTarget.Menu,
					Source = Button8
				}
			};

			AnalogMappings = new[] {
				new InputControlMapping {
					Handle = "Left Stick X",
					Target = InputControlTarget.LeftStickX,
					Source = Analog0
				},
				new InputControlMapping {
					Handle = "Left Stick Y",
					Target = InputControlTarget.LeftStickY,
					Source = Analog1,
					Invert = true
				},
				new InputControlMapping {
					Handle = "Right Stick X",
					Target = InputControlTarget.RightStickX,
					Source = Analog3
				},
				new InputControlMapping {
					Handle = "Right Stick Y",
					Target = InputControlTarget.RightStickY,
					Source = Analog4,
					Invert = true
				},
				new InputControlMapping {
					Handle = "DPad X",
					Target = InputControlTarget.DPadX,
					Source = Analog6,
					SourceRange = InputControlMapping.Range.Complete,
					TargetRange = InputControlMapping.Range.Complete
				},
				new InputControlMapping {
					Handle = "DPad Y",
					Target = InputControlTarget.DPadY,
					Source = Analog7,
					SourceRange = InputControlMapping.Range.Complete,
					TargetRange = InputControlMapping.Range.Complete,
				},
				new InputControlMapping {
					Handle = "Left Trigger",
					Target = InputControlTarget.LeftTrigger,
					Source = Analog2
				},
				new InputControlMapping {
					Handle = "Right Trigger",
					Target = InputControlTarget.RightTrigger,
					Source = Analog5
				}
			};
		}
	}
}

