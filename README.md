# Final Regular - Inteligencia Artificial en Videojuegos

## Parte práctica

En este ejercicio se entrega un proyecto base en Unity con una escena simple de navegación.

La escena contiene:

- un **Player**
- un **Enemy**
- una **plataforma**
- uno o más **obstáculos**
- un sistema de nodos generado automáticamente mediante un **NodeManager**
- una base de código para trabajar con **Dijkstra**

El objetivo del ejercicio es completar y corregir la lógica necesaria para que el enemigo pueda encontrar y recorrer un camino válido dentro de la escena.

---

## Objetivo general

Lograr que el enemigo pueda:

1. utilizar correctamente la red de nodos sobre la plataforma
2. encontrar un camino desde un punto inicial hasta un punto objetivo usando **Dijkstra**
3. recorrer correctamente el camino encontrado sin atravesar obstáculos

---

## Lo que ya está hecho

El proyecto ya incluye:

- la escena base
- el `NodeManager`
- los nodos generados automáticamente
- el prefab o script base de `Node`
- un script base de `Dijkstra`
- un agente que puede recorrer una lista de nodos
- objetos de inicio y destino

---

## Lo que deben hacer

### 1. Configurar correctamente el NodeManager

El proyecto incluye un `NodeManager`, pero su configuración no está terminada.

Deben revisar y ajustar los parámetros necesarios para que los nodos se generen correctamente sobre la plataforma de la escena.

Se espera que:

- los nodos cubran el área útil de la plataforma
- no aparezcan dentro de obstáculos
- las conexiones entre nodos sean coherentes

---

### 2. Revisar y completar la implementación de Dijkstra

El proyecto incluye una base del algoritmo de **Dijkstra**, pero no está completamente funcional.

Deben corregir o completar la lógica necesaria para que el algoritmo pueda:

- recorrer nodos válidos
- calcular correctamente los costos
- elegir el siguiente nodo adecuado
- reconstruir el camino final

---

### 3. Lograr que el enemigo recorra correctamente el camino

Una vez obtenido el camino, el enemigo debe poder seguirlo correctamente dentro de la escena.

Se espera que:

- avance nodo por nodo
- llegue al objetivo
- no atraviese obstáculos
- no se quede detenido sin motivo

---

## Qué se evalúa

Se tendrá en cuenta:

- correcta configuración y uso del `NodeManager`
- implementación correcta de **Dijkstra**
- reconstrucción correcta del camino
- integración entre búsqueda y movimiento
- funcionamiento general del sistema en la escena

---

## Aclaraciones

- No se pide implementar **A\*** ni **Theta\*** en esta parte práctica.
- No se pide armar el proyecto desde cero.
- No se pide modificar por completo la escena.
- Se puede ajustar la configuración de nodos y revisar el código provisto.
- El foco del ejercicio está en **navegación y pathfinding**.

---

## Resumen rápido

El objetivo es que el enemigo:

- use una red de nodos válida
- encuentre un camino con Dijkstra
- recorra correctamente ese camino evitando la pared
