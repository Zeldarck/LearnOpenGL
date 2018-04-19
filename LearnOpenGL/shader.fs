#version 330 core
in vec4 OurColor;
in vec2 TexCoord;

out vec4 FragColor;

uniform sampler2D texture0;

void main()
{
    FragColor = texture(texture0, TexCoord) * vec4(OurColor, 1.0);//vec4(TexCoord,0,0);//texture(texture1, TexCoord) * vec4(ourColor, 1.0);  
}