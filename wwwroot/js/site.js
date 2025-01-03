const intro = document.getElementById('intro');
const text = intro.textContent;
intro.textContent = ' ';
let i = 0;

function typeWriter() {
  if (i < text.length) {
    intro.textContent += text.charAt(i);
    i++;
    setTimeout(typeWriter, 30);
  }
}

window.onload = typeWriter;