# GameEngineFinalCourseProject
Link to YouTube video report/live demo: https://youtu.be/el0yss6_7bA

Laith Ghannam 100895645 for INFR 3110U - Game Engine Design & Implementation

IMPORTANT Click on sample scene to load the actual game scene if you wish not to display win/lose screens

Expanded the previous game created for Course Project Progression (https://github.com/laithooo/CourseProjectProgressionGameEngine) to improve previous implemented design patterns and added optimization design patterns

Improvement of factory design pattern code was by me using minor tweaks, removing extra spawns, and by changing prefabs scale.

For the GoblinObjectPooling class/file:

Majority of the code was coded using tips and similar concepts from lectures 9.6 and 9.7. However I've run into a few issues in the original GoblinObjectPooling class where at runtime Unity would tell me my queue for instantiating for the goblins is null and that the queue was empty. So by consulting AI I was able to expand on the code I've created in the public GameObject Get() function as shown in the image below that whenever my queue or count is at 0 it will add and instantiate the goblins which fixed all of my errors.

<img width="639" height="279" alt="Screenshot 2025-11-26 190656" src="https://github.com/user-attachments/assets/ec68efd4-5ee3-40a2-8863-0d8a6940c667" />

For the IHealthObserver & PlayerHealth & HealthUI & HealthManager files:

I've gotten the base codes from codes I've written for the week 9 in class activity, but they've all been heavily modified to fit this scene because week 9's game was a very basic game where health gets changed whenever car collides with any gameobject. But this new updated and modified code allows the player to only take 20 damage from each goblin hit but keeping the original logic where if they fall into a pit the player instantly dies.

<img width="442" height="209" alt="image" src="https://github.com/user-attachments/assets/d9970600-ee5f-42a8-ba7b-c2a6e1d3768d" /> <img width="387" height="190" alt="image" src="https://github.com/user-attachments/assets/2c59557d-7e19-43e6-bb67-23d451fb76ae" />

















Assets credits: Goblin model and animations: https://assetstore.unity.com/packages/3d/characters/goblin-lowpoly-animation-311643 Dungeon models: https://assetstore.unity.com/packages/3d/props/furniture/3d-dungeon-lowpoly-pack-231265 Knight playermodel and animations: https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/rpg-hero-pbr-hp-polyart-121480
