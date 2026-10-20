// Makes any element with a data-glow attribute glow as the pointer gets closer.
// Runs entirely in the browser (no Blazor round trips on mouse move).
(() => {
  const RADIUS = 260; // px: how far away the glow starts

  const update = (x, y) => {
    document.querySelectorAll('[data-glow]').forEach((el) => {
      const r = el.getBoundingClientRect();
      const dx = Math.max(r.left - x, 0, x - r.right);
      const dy = Math.max(r.top - y, 0, y - r.bottom);
      const strength = Math.max(0, 1 - Math.hypot(dx, dy) / RADIUS);
      el.style.setProperty('--glow', strength.toFixed(3));
    });
  };

  document.addEventListener('pointermove', (e) => update(e.clientX, e.clientY), { passive: true });
  document.documentElement.addEventListener('mouseleave', () => update(-9999, -9999));
})();
