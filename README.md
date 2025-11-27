# GameEngineFinalCourseProject
Link to YouTube video report/live demo:

Laith Ghannam 100895645 for INFR 3110U - Game Engine Design & Implementation

Expanded the previous game created for Course Project Progression (https://github.com/laithooo/CourseProjectProgressionGameEngine) to improve previous implemented design patterns and added optimization design patterns

Improvement of factory design pattern code was by me using minor tweaks, removing extra spawns, and by changing prefabs scale.

For the GoblinObjectPooling class/file:

Majority of the code was coded using tips and similar concepts from lectures 9.6 and 9.7. However I've run into a few issues in the original GoblinObjectPooling class where at runtime Unity would tell me my queue for instantiating for the goblins is null and that the queue was empty. So by consulting AI I was able to expand on the code I've created in the public GameObject Get() function as shown in the image below that whenever my queue or count is at 0 it will add and instantiate the goblins which fixed all of my errors.

<img width="639" height="279" alt="Screenshot 2025-11-26 190656" src="https://github.com/user-attachments/assets/ec68efd4-5ee3-40a2-8863-0d8a6940c667" />














Assets credits: Goblin model and animations: https://assetstore.unity.com/packages/3d/characters/goblin-lowpoly-animation-311643 Dungeon models: https://assetstore.unity.com/packages/3d/props/furniture/3d-dungeon-lowpoly-pack-231265 Knight playermodel and animations: https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/rpg-hero-pbr-hp-polyart-121480
