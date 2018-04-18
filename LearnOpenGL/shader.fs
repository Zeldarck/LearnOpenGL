#version 330 core
in vec4 ourColor;
out vec4 FragColor;
uniform vec4 OurColor;
void main()
{
   FragColor = ourColor + OurColor;
}