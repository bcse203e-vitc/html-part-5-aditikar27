/* General Reset */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #f4f4f4;
    overflow: hidden;
}

#loading-screen {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: rgba(255, 255, 255, 0.8);
    display: flex;
    justify-content: center;
    align-items: center;
    z-index: 9999;
}

.spinner {
    border: 8px solid #f3f3f3; /* Light gray border */
    border-top: 8px solid #3498db; /* Blue color for the spinner */
    border-radius: 50%;
    width: 50px;
    height: 50px;
    animation: spin 2s linear infinite;
}

/* Animation for the spinning effect */
@keyframes spin {
    0% { transform: rotate(0deg); }
    100% { transform: rotate(360deg); }
}

#main-content {
    display: none;
    width: 80%;
    max-width: 800px;
    margin: 20px auto;
    text-align: center;
}

header h1 {
    font-size: 2rem;
    color: #333;
}

section {
    padding: 20px;
    background-color: #fff;
    margin: 20px 0;
    border-radius: 8px;
    box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
}

section h2 {
    font-size: 1.5rem;
    color: #333;
}

section p {
    font-size: 1rem;
    color: #666;
}
