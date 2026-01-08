# 🎮 Roll-a-Ball — Unity Mini Game (AI + Physics)
# 🎮 Roll-a-Ball — Unity Mini Game (AI + Physics)

A polished **Roll-a-Ball mini game** developed using **Unity 2022 (LTS)**, showcasing essential game-development principles such as **physics-based movement, NavMesh-driven AI, collision layering, and clean UI state management**.

This project emphasizes not only gameplay mechanics, but also **correct engineering practices** commonly applied in real-world Unity projects.

---

## 🧠 Why This Project Matters

This is **not a basic tutorial clone**.  
It demonstrates **problem-solving ability**, **engine-level understanding**, and a **production-oriented setup**, particularly in areas that often challenge Unity developers:

- Practical handling of **NavMeshAgent limitations**
- Clear separation of **physics colliders vs trigger colliders**
- Use of the **Layer Collision Matrix** for interaction control
- Stable and predictable **win/lose state logic**
- Debug-driven development and refinement

---

## 🎯 Game Objective

- Control a rolling player ball
- Collect all pickups to **win**
- Avoid the enemy AI — enemy proximity results in **loss**
- Enemy intelligently navigates around obstacles using **NavMesh**

---

## ✨ Key Features & Strengths

### 🎮 Physics-Based Player Movement
- Rigidbody-driven movement system
- Smooth and responsive controls
- Gravity-aware interaction with ground and obstacles

---

### 🤖 Intelligent Enemy AI (NavMesh)
- Enemy movement powered by **NavMeshAgent**
- Dynamic player tracking with obstacle avoidance
- Correct handling of NavMesh stopping distance
- Trigger-based detection for a reliable lose condition

✔ Demonstrates real-world NavMesh usage  
✔ Avoids direct `Transform` manipulation

---

### 🎯 Robust Pickup System
- Trigger-based pickup detection
- Real-time score updates
- Pickups deactivate upon collection
- Long-distance pickup prevented using the **Layer Collision Matrix**

✔ Reflects proper use of Unity’s physics filtering system

---

### 🧩 Clean Collision Architecture

| Purpose | Implementation |
|------|------|
| Ground & Walls | Physics Colliders |
| Enemy Detection | Trigger Colliders |
| Pickup Detection | Layer-filtered Triggers |
| AI Navigation | NavMeshAgent |

✔ Avoids common beginner pitfalls  
✔ Designed to scale cleanly with added complexity

---

### 🖥️ Polished UI (TextMeshPro)
- Live score counter
- Clear **Win** and **Lose** feedback
- Safe UI updates during gameplay
- Well-structured Canvas hierarchy

---

## 🎮 Controls

| Action | Input |
|------|------|
| Move Player | Arrow Keys / WASD |
| Play | Unity Editor |

*(Input handled using the Unity Input System)*

---

## 🛠️ Tech Stack

- **Unity 2022.3 LTS**
- **C#**
- **NavMeshAgent**
- **Unity Input System**
- **TextMeshPro**
- **Physics & Trigger Colliders**
- **Layer Collision Matrix**

---

## ⚙️ Core Systems Overview

### Player Controller
- Rigidbody-based movement
- Trigger handling for pickups and enemy detection
- Centralized win/lose state management

### Enemy Controller
- NavMesh-driven movement logic
- Continuous player tracking
- Non-blocking trigger-based hit detection

### Physics Strategy
- Physics colliders for environment interaction
- Trigger colliders for detection logic
- Layer filtering to prevent unintended interactions

---

## 🧪 Gameplay Flow

1. Player spawns in the arena  
2. Enemy begins navigating toward the player  
3. Player collects pickups to increase score  
4. All pickups collected → **You Win**  
5. Enemy reaches the player → **You Lose**

---

## 🚀 Future Improvements

- Restart / reset functionality
- Sound effects and background music
- Enemy animations
- Multiple levels
- Difficulty scaling (enemy speed and count)

---

## ✅ Conclusion

This Roll-a-Ball project goes beyond a simple playable prototype and reflects a **strong understanding of Unity’s core systems** and how they interact in practical scenarios.

Key challenges—including **NavMesh behavior**, **trigger vs collision mechanics**, and **layer-based interaction control**—were addressed using **clean, scalable solutions** rather than temporary workarounds.

The final result demonstrates:
- Clear separation between physics and detection logic  
- Reliable AI behavior using NavMeshAgent  
- Proper use of Unity’s Layer Collision Matrix  
- Maintainable, readable gameplay code  

Overall, this project serves as a solid foundation for more advanced Unity development and stands as a **portfolio-ready example** of practical, real-world game engineering skills.
