const API_BASE = "http://localhost:5000/api";

export async function getVehicles() {
    const res = await fetch(`${API_BASE}/Vehicles`);
    return await res.json();
}

export async function addVehicle(vehicle) {
    const res = await fetch(`${API_BASE}/Vehicles`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(vehicle)
    });
    return await res.json();
}

export async function deleteVehicle(id) {
    await fetch(`${API_BASE}/Vehicles/${id}`, {
        method: "DELETE"
    });
}
