# An Exiled (SCP:SL) plugin that adds Cerveza Cristal.

Plugin that adds Cerveza Cristal.

It is my third plugin, its not useful at all, but it may be fun.

You need to manually add the sound file to EXILED/Configs/CervezaCristal
File: https://files.fm/u/kg3587k8v3

Features:
 - Adds custom item Cerveza Cristal
 - Plays Cerveza Cristal theme when used
 - You can replace the sound with everything you want. (You need a proper file, it must be .ogg, mono sound, and 48000hz) 
 - Fully translatabe.

 Default Config:
 ```yml 
advanced_tesla:
  is_enabled: true
  debug: false
  # Indicates wheter cassie should inform about Class D dying on tesla gate.
  is_class_d_cassie_enabled: true
  # The content of the cassie message after Class D dies on tesla gate. (Use {TeamMembersAlive} to get the number of reamining team members of the dying player)
  class_d_cassie_content: 'classd personnel successfully terminated by automatic security system . awaitingrecontainment {TeamMembersAlive} class d personnel'
  # The content of the text message after Class D dies on tesla gate.
  class_d_cassie_text: 'Class D personnel successfully terminated by Automatic Serucity System. Awaiting recontainment of {TeamMembersAlive} class d personnel.'
  # Indicates wheter cassie should inform about Class D dying on tesla gate.
  is_chaos_insurgency_cassie_enabled: true
  # The content of the cassie message after Chaos Insurgency dies on tesla gate.
  chaos_insurgency_cassie_content: 'chaosinsurgency agent successfully terminated by automatic security system . awaitingrecontainment {TeamMembersAlive} chaosinsurgency agents'
  # The content of the text message after Chaos Insurgency dies on tesla gate.
  chaos_insurgency_cassie_text: 'Chaos Insurgency agent successfully terminated by Automatic Security System. Awaiting recontainment of {TeamMembersAlive} Chaos Insurgency agents.'
 ```

 Made with a little help of people from exiled beginner-talk channel again. Thank you all <3
