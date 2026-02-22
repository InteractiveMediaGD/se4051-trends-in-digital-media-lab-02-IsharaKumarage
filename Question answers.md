# Reflection Questions Answers

1. **What does the Detection Zone simulate in a “smart environment”?**

   The detection zone simulates a sensor system in a smart environment. It acts like motion sensors or proximity detectors used in real-world systems such as automatic doors, security systems, or smart lighting. It detects the presence of a user and triggers actions based on that detection.

2. **How does the NPC decide when to move?**

   The NPC calculates the distance between itself and the player using a distance function. If the player is within a specified range (chase distance), the NPC begins to move toward the player. Otherwise, it remains idle.

3. **What changes made the environment feel more responsive?**

   Several changes contributed to a more responsive environment:
   - Real-time detection using trigger colliders
   - Immediate visual feedback through light color changes
   - Audio feedback when entering the zone
   - NPC reacting dynamically to the player's position
   - Debug logs that confirm system interactions

   These elements together create a more interactive and reactive experience.

4. **If you had real AI, what would you improve in this scene?**

   With real AI, the system could be significantly improved by:
   - Adding intelligent pathfinding (NPC avoids obstacles)
   - Implementing behavior states (idle, patrol, chase, flee)
   - Using machine learning to adapt to player behavior
   - Adding animations and realistic reactions
   - Improving environmental responses based on multiple conditions
   - Enabling communication between multiple NPCs

   This would make the environment more realistic, immersive, and intelligent.
