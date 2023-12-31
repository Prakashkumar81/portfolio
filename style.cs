@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;700&family=Roboto&display=swap');

*{
    margin: 0;
    padding: 0;
}
body{
    /* background-color: rgb(0,0,33);
    color: white; */
    font-family: 'Poppins', sans-serif;
}

nav{
    display: flex;
    justify-content: space-around;
    align-items: center;
    height: 70px;
    background-color: #5C9CE5;
}
nav ul{
    display: flex;
    justify-content: center;
    font-size: 1.2rem;
}
nav ul li{
    list-style: none;
    margin: 0 20px;
}
nav ul li a{
    text-decoration: none;
    color: black;
}
nav ul li a:hover{
    color: white;
    font-weight:bold;
}
.icn{
    border-radius: 100%;
    height: 40px;
    background-color: #B5D8FF;
    transform: translate(-5px,10px);
}
.left{
    font-size:  1.5rem;
    transform: translate(0,-8px);
}
.firstSection{
    display: flex;
    justify-content: center;
    align-items:center;
    height: 93vh;
    background-color: #B5D8FF;
}
.btn{
    background-color:#5C9CE5;
    border: 2px solid white;
    border-radius: 5px;
    font-size: 20px;
    padding:10px 15px;
    cursor: pointer;
    margin-top: 50px;
    margin-right: 30px;
}
.btn:hover{
    color: white;
}
.buttons a{
    color: black;
    text-decoration: none;
}
.buttons a:hover{
    color: white;
}
/* .firstSection div{
    width: 30%;
} */
.leftSection{
    font-size: 2rem;
}
.leftSection h1{
    margin-bottom: 30px;
}
.blue{
    color: #0f6dd8;
}
#element{
    color: #0f6dd8;
}
.about{
    margin: 0 80px;
    display: flex;
    flex-direction: column;
    align-items: center;
    height: 60vh;
}
.about-first{
    margin:40px 0;
}
.about-second{
    display: flex;
    justify-content: space-between;
}
.about-left{
    width: 40%;
}
.about-right{
    width: 40%;
}
.about-left div button{
    margin-top: 30px;
}
.about-second h3{
    margin-bottom: 20px;
}
.about-right div{
    display: flex;
    align-content: space-around;
}
.skills{
    background-color: rgb(206, 206, 206);
    margin-bottom: 10px;
    height: fit-content;
    width: fit-content;
    padding: 10px 15px;
    border-radius: 5px;
}
.projects{
    display: flex;
    margin: 80px 80px;
    flex-direction: column;
    align-items: center;
    
}
.project-heading h2{
    text-align: center;
}
.project-left{
    width: 40%;
}
.project-right{
    width: 40%;
}
.project{
    display: flex;
    justify-content: space-between;
    margin-bottom: 80px;
}
.projects h2{
    margin-bottom: 40px;
}
.project-right h3{
    margin-bottom: 20px;
}

.project-left img{
    margin-top: 30px;
    height: 200px;
    border-radius: 5px;
}
.project-right button{
    margin-top: 30px;
}
.project-right button a{
    text-decoration: none;
    color: black;
}
.project-right button a:hover{
    color: white;
}
.contact{
    display: flex;
    flex-direction: column;
    align-items: center;
    height: 850px;
    background-color: #B5D8FF;
}
.contact h2{
    margin:40px 0;
}
.contact-form{
    height: 620px;
    width: 500px;
    background-color: white;
    border-radius: 5px;

}
form{
    padding: 40px;
    font-size: 1.2rem;
}
form input{
    border: none;
    background-color:rgb(235, 235, 235);
    font-size: 1.2rem;
    border-radius: 5px;
    padding:10px 0;
    margin: 10px 0;
    width: 100%;
}
form textarea{
    width: 100%;
    border: none;
    background-color: rgb(235, 235, 235);
    font-size: 1.2rem;
    border-radius: 5px;
    padding: 10px 0px;
    margin: 10px 0;
    width: 100%;
}
form button{
    margin-top: 0;
}
footer{
    background-color:black;
    color: white;
    height: 40px;
    display: flex;
    justify-content: center;
    align-items: center;
}