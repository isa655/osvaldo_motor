* {
    box-sizing: border-box;
}

body {
    margin: 0;
    background-color: #111111;
    color: #ffffff;
    font-family: Arial, sans-serif;
    font-size: 18px;
}

nav {
    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-wrap: wrap;
    gap: 20px;
    padding: 15px 40px;
    background-color: #f58220;
}

.identidade {
    display: flex;
    align-items: center;
    gap: 15px;
}

.identidade img {
    width: 80px;
    height: 80px;
    object-fit: cover;
    border-radius: 50%;
}

.identidade h1 {
    margin: 0;
    color: #111111;
    font-size: 30px;
}

.menu {
    display: flex;
    align-items: center;
    gap: 25px;
    flex-wrap: wrap;
}

.menu a {
    color: #111111;
    text-decoration: none;
    font-weight: bold;
}

.menu a:hover {
    color: #ffffff;
}

header {
    width: 100%;
    padding: 0;
    margin: 0;
}

.banner {
    display: block;
    width: 100%;
    max-width: none;
    height: 300px;
    object-fit: cover;
    margin: 0;
    border-radius: 0;
}

main {
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
}

h1 {
    color: #f58220;
    font-size: 40px;
}

h2 {
    color: #f58220;
    font-size: 28px;
    margin-top: 30px;
}

p {
    font-size: 18px;
    line-height: 1.6;
}

ul {
    background-color: #222222;
    padding: 25px 45px;
    border-radius: 10px;
    border-left: 5px solid #f58220;
}

li {
    margin-bottom: 10px;
}

.imagens {
    display: flex;
    justify-content: center;
    align-items: stretch;
    flex-wrap: wrap;
    gap: 20px;
}

.card {
    flex: 0 1 calc(33.333% - 25px);
    min-width: 220px;
    padding: 18px;
    background-color: #222222;
    border-radius: 18px;
    text-align: center;
    box-shadow: 0 4px 12px rgba(245, 130, 32, 0.2);
}

.card img {
    width: 100%;
    max-width: 500px;
    height: 30px;
    object-fit: cover;
    border-radius: 14px;
}

.card h3 {
    color: #f58220;
    font-size: 21px;
    margin: 15px 0 10px;
}

.card p {
    color: #dddddd;
    font-size: 15px;
    line-height: 1.5;
}

table {
    width: 100%;
    border-collapse: collapse;
    background-color: #222222;
    margin-top: 20px;
}

th,
td {
    border: 1px solid #f58220;
    padding: 15px;
    text-align: left;
}

th {
    background-color: #f58220;
    color: #111111;
}

.regras {
    background-color: #222222;
    padding: 20px;
    margin-top: 30px;
    border-radius: 10px;
    border-left: 5px solid #f58220;
}

footer {
    background-color: #f58220;
    color: #111111;
    text-align: center;
    padding: 25px;
    margin-top: 30px;
}

footer h2 {
    color: #111111;
}