/*
! tailwindcss v3.3.5 | MIT License | https://tailwindcss.com
*/

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: #e5e7eb;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
5. Use the user's configured `sans` font-feature-settings by default.
6. Use the user's configured `sans` font-variation-settings by default.
*/

html {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  -moz-tab-size: 4;
  /* 3 */
  -o-tab-size: 4;
     tab-size: 4;
  /* 3 */
  font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
  font-feature-settings: normal;
  /* 5 */
  font-variation-settings: normal;
  /* 6 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-feature-settings: inherit;
  /* 1 */
  font-variation-settings: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  font-weight: inherit;
  /* 1 */
  line-height: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Reset default styling for dialogs.
*/

dialog {
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */

[hidden] {
  display: none;
}

:root,
[data-theme] {
  background-color: hsl(var(--b1) / var(--tw-bg-opacity, 1));
  color: hsl(var(--bc) / var(--tw-text-opacity, 1));
}

html {
  -webkit-tap-highlight-color: transparent;
}

:root {
  color-scheme: light;
  --pf: 259 94% 44%;
  --sf: 314 100% 40%;
  --af: 174 75% 39%;
  --nf: 214 20% 14%;
  --in: 198 93% 60%;
  --su: 158 64% 52%;
  --wa: 43 96% 56%;
  --er: 0 91% 71%;
  --inc: 198 100% 12%;
  --suc: 158 100% 10%;
  --wac: 43 100% 11%;
  --erc: 0 100% 14%;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-text-case: uppercase;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 259 94% 51%;
  --pc: 259 96% 91%;
  --s: 314 100% 47%;
  --sc: 314 100% 91%;
  --a: 174 75% 46%;
  --ac: 174 75% 11%;
  --n: 214 20% 21%;
  --nc: 212 19% 87%;
  --b1: 0 0% 100%;
  --b2: 0 0% 95%;
  --b3: 180 2% 90%;
  --bc: 215 28% 17%;
}

@media (prefers-color-scheme: dark) {
  :root {
    color-scheme: dark;
    --pf: 262 80% 43%;
    --sf: 316 70% 43%;
    --af: 175 70% 34%;
    --in: 198 93% 60%;
    --su: 158 64% 52%;
    --wa: 43 96% 56%;
    --er: 0 91% 71%;
    --inc: 198 100% 12%;
    --suc: 158 100% 10%;
    --wac: 43 100% 11%;
    --erc: 0 100% 14%;
    --rounded-box: 1rem;
    --rounded-btn: 0.5rem;
    --rounded-badge: 1.9rem;
    --animation-btn: 0.25s;
    --animation-input: .2s;
    --btn-text-case: uppercase;
    --btn-focus-scale: 0.95;
    --border-btn: 1px;
    --tab-border: 1px;
    --tab-radius: 0.5rem;
    --p: 262 80% 50%;
    --pc: 0 0% 100%;
    --s: 316 70% 50%;
    --sc: 0 0% 100%;
    --a: 175 70% 41%;
    --ac: 0 0% 100%;
    --n: 213 18% 20%;
    --nf: 212 17% 17%;
    --nc: 220 13% 69%;
    --b1: 212 18% 14%;
    --b2: 213 18% 12%;
    --b3: 213 18% 10%;
    --bc: 220 13% 69%;
  }
}

[data-theme=light] {
  color-scheme: light;
  --pf: 259 94% 44%;
  --sf: 314 100% 40%;
  --af: 174 75% 39%;
  --nf: 214 20% 14%;
  --in: 198 93% 60%;
  --su: 158 64% 52%;
  --wa: 43 96% 56%;
  --er: 0 91% 71%;
  --inc: 198 100% 12%;
  --suc: 158 100% 10%;
  --wac: 43 100% 11%;
  --erc: 0 100% 14%;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-text-case: uppercase;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 259 94% 51%;
  --pc: 259 96% 91%;
  --s: 314 100% 47%;
  --sc: 314 100% 91%;
  --a: 174 75% 46%;
  --ac: 174 75% 11%;
  --n: 214 20% 21%;
  --nc: 212 19% 87%;
  --b1: 0 0% 100%;
  --b2: 0 0% 95%;
  --b3: 180 2% 90%;
  --bc: 215 28% 17%;
}

[data-theme=dark] {
  color-scheme: dark;
  --pf: 262 80% 43%;
  --sf: 316 70% 43%;
  --af: 175 70% 34%;
  --in: 198 93% 60%;
  --su: 158 64% 52%;
  --wa: 43 96% 56%;
  --er: 0 91% 71%;
  --inc: 198 100% 12%;
  --suc: 158 100% 10%;
  --wac: 43 100% 11%;
  --erc: 0 100% 14%;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-text-case: uppercase;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 262 80% 50%;
  --pc: 0 0% 100%;
  --s: 316 70% 50%;
  --sc: 0 0% 100%;
  --a: 175 70% 41%;
  --ac: 0 0% 100%;
  --n: 213 18% 20%;
  --nf: 212 17% 17%;
  --nc: 220 13% 69%;
  --b1: 212 18% 14%;
  --b2: 213 18% 12%;
  --b3: 213 18% 10%;
  --bc: 220 13% 69%;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

.avatar.placeholder > div {
  display: flex;
  align-items: center;
  justify-content: center;
}

@media (hover:hover) {
  .table tr.hover:hover,
  .table tr.hover:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: hsl(var(--b2) / var(--tw-bg-opacity));
  }

  .table-zebra tr.hover:hover,
  .table-zebra tr.hover:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: hsl(var(--b3) / var(--tw-bg-opacity));
  }
}

.btn {
  display: inline-flex;
  flex-shrink: 0;
  cursor: pointer;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
  border-color: transparent;
  border-color: hsl(var(--b2) / var(--tw-border-opacity));
  text-align: center;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-duration: 200ms;
  border-radius: var(--rounded-btn, 0.5rem);
  height: 3rem;
  padding-left: 1rem;
  padding-right: 1rem;
  min-height: 3rem;
  font-size: 0.875rem;
  line-height: 1em;
  gap: 0.5rem;
  font-weight: 600;
  text-decoration-line: none;
  border-width: var(--border-btn, 1px);
  animation: button-pop var(--animation-btn, 0.25s) ease-out;
  text-transform: var(--btn-text-case, uppercase);
  --tw-border-opacity: 1;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b2) / var(--tw-bg-opacity));
  --tw-text-opacity: 1;
  color: hsl(var(--bc) / var(--tw-text-opacity));
  outline-color: hsl(var(--bc) / 1);
}

.btn-disabled,
  .btn[disabled],
  .btn:disabled {
  pointer-events: none;
}

.btn-group > input[type="radio"].btn {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.btn-group > input[type="radio"].btn:before {
  content: attr(data-title);
}

.btn:is(input[type="checkbox"]),
.btn:is(input[type="radio"]) {
  width: auto;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.btn:is(input[type="checkbox"]):after,
.btn:is(input[type="radio"]):after {
  --tw-content: attr(aria-label);
  content: var(--tw-content);
}

.checkbox {
  flex-shrink: 0;
  --chkbg: var(--bc);
  --chkfg: var(--b1);
  height: 1.5rem;
  width: 1.5rem;
  cursor: pointer;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  border-width: 1px;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  --tw-border-opacity: 0.2;
  border-radius: var(--rounded-btn, 0.5rem);
}

@media (hover: hover) {
  .btm-nav > *.disabled:hover,
      .btm-nav > *[disabled]:hover {
    pointer-events: none;
    --tw-border-opacity: 0;
    background-color: hsl(var(--n) / var(--tw-bg-opacity));
    --tw-bg-opacity: 0.1;
    color: hsl(var(--bc) / var(--tw-text-opacity));
    --tw-text-opacity: 0.2;
  }

  .btn:hover {
    --tw-border-opacity: 1;
    border-color: hsl(var(--b3) / var(--tw-border-opacity));
    --tw-bg-opacity: 1;
    background-color: hsl(var(--b3) / var(--tw-bg-opacity));
  }

  .btn.glass:hover {
    --glass-opacity: 25%;
    --glass-border-opacity: 15%;
  }

  .btn-disabled:hover,
    .btn[disabled]:hover,
    .btn:disabled:hover {
    --tw-border-opacity: 0;
    background-color: hsl(var(--n) / var(--tw-bg-opacity));
    --tw-bg-opacity: 0.2;
    color: hsl(var(--bc) / var(--tw-text-opacity));
    --tw-text-opacity: 0.2;
  }

  .btn:is(input[type="checkbox"]:checked):hover, .btn:is(input[type="radio"]:checked):hover {
    --tw-border-opacity: 1;
    border-color: hsl(var(--pf) / var(--tw-border-opacity));
    --tw-bg-opacity: 1;
    background-color: hsl(var(--pf) / var(--tw-bg-opacity));
  }
}

.input {
  flex-shrink: 1;
  height: 3rem;
  padding-left: 1rem;
  padding-right: 1rem;
  font-size: 1rem;
  line-height: 2;
  line-height: 1.5rem;
  border-width: 1px;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  --tw-border-opacity: 0;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b1) / var(--tw-bg-opacity));
  border-radius: var(--rounded-btn, 0.5rem);
}

.input-group > .input {
  isolation: isolate;
}

.input-group > *,
  .input-group > .input,
  .input-group > .textarea,
  .input-group > .select {
  border-radius: 0px;
}

.join {
  display: inline-flex;
  align-items: stretch;
  border-radius: var(--rounded-btn, 0.5rem);
}

.join :where(.join-item) {
  border-start-end-radius: 0;
  border-end-end-radius: 0;
  border-end-start-radius: 0;
  border-start-start-radius: 0;
}

.join .join-item:not(:first-child):not(:last-child),
  .join *:not(:first-child):not(:last-child) .join-item {
  border-start-end-radius: 0;
  border-end-end-radius: 0;
  border-end-start-radius: 0;
  border-start-start-radius: 0;
}

.join .join-item:first-child:not(:last-child),
  .join *:first-child:not(:last-child) .join-item {
  border-start-end-radius: 0;
  border-end-end-radius: 0;
}

.join .dropdown .join-item:first-child:not(:last-child),
  .join *:first-child:not(:last-child) .dropdown .join-item {
  border-start-end-radius: inherit;
  border-end-end-radius: inherit;
}

.join :where(.join-item:first-child:not(:last-child)),
  .join :where(*:first-child:not(:last-child) .join-item) {
  border-end-start-radius: inherit;
  border-start-start-radius: inherit;
}

.join .join-item:last-child:not(:first-child),
  .join *:last-child:not(:first-child) .join-item {
  border-end-start-radius: 0;
  border-start-start-radius: 0;
}

.join :where(.join-item:last-child:not(:first-child)),
  .join :where(*:last-child:not(:first-child) .join-item) {
  border-start-end-radius: inherit;
  border-end-end-radius: inherit;
}

@supports not selector(:has(*)) {
  :where(.join *) {
    border-radius: inherit;
  }
}

@supports selector(:has(*)) {
  :where(.join *:has(.join-item)) {
    border-radius: inherit;
  }
}

.link {
  cursor: pointer;
  text-decoration-line: underline;
}

.menu li.disabled {
  cursor: not-allowed;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  color: hsl(var(--bc) / 0.3);
}

.progress {
  position: relative;
  width: 100%;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  overflow: hidden;
  height: 0.5rem;
  background-color: hsl(var(--bc) / 0.2);
  border-radius: var(--rounded-box, 1rem);
}

.radio {
  flex-shrink: 0;
  --chkbg: var(--bc);
  height: 1.5rem;
  width: 1.5rem;
  cursor: pointer;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  border-radius: 9999px;
  border-width: 1px;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  --tw-border-opacity: 0.2;
}

.select {
  display: inline-flex;
  cursor: pointer;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  height: 3rem;
  padding-left: 1rem;
  padding-right: 2.5rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
  min-height: 3rem;
  border-width: 1px;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  --tw-border-opacity: 0;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b1) / var(--tw-bg-opacity));
  border-radius: var(--rounded-btn, 0.5rem);
  background-image: linear-gradient(45deg, transparent 50%, currentColor 50%),
    linear-gradient(135deg, currentColor 50%, transparent 50%);
  background-position: calc(100% - 20px) calc(1px + 50%),
    calc(100% - 16.1px) calc(1px + 50%);
  background-size: 4px 4px,
    4px 4px;
  background-repeat: no-repeat;
}

.select[multiple] {
  height: auto;
}

.swap {
  position: relative;
  display: inline-grid;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  place-content: center;
  cursor: pointer;
}

.swap > * {
  grid-column-start: 1;
  grid-row-start: 1;
  transition-duration: 300ms;
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-property: transform, opacity;
}

.swap input {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.swap .swap-on,
.swap .swap-indeterminate,
.swap input:indeterminate ~ .swap-on {
  opacity: 0;
}

.swap input:checked ~ .swap-off,
.swap-active .swap-off,
.swap input:indeterminate ~ .swap-off {
  opacity: 0;
}

.swap input:checked ~ .swap-on,
.swap-active .swap-on,
.swap input:indeterminate ~ .swap-indeterminate {
  opacity: 1;
}

.table {
  position: relative;
  width: 100%;
  text-align: left;
  font-size: 0.875rem;
  line-height: 1.25rem;
  border-radius: var(--rounded-box, 1rem);
}

.table :where(.table-pin-rows thead tr) {
  position: sticky;
  top: 0px;
  z-index: 1;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b1) / var(--tw-bg-opacity));
}

.table :where(.table-pin-rows tfoot tr) {
  position: sticky;
  bottom: 0px;
  z-index: 1;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b1) / var(--tw-bg-opacity));
}

.table :where(.table-pin-cols tr th) {
  position: sticky;
  left: 0px;
  right: 0px;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b1) / var(--tw-bg-opacity));
}

.textarea {
  flex-shrink: 1;
  min-height: 3rem;
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
  border-width: 1px;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  --tw-border-opacity: 0;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b1) / var(--tw-bg-opacity));
  border-radius: var(--rounded-btn, 0.5rem);
}

.toggle {
  flex-shrink: 0;
  --tglbg: hsl(var(--b1));
  --handleoffset: 1.5rem;
  --handleoffsetcalculator: calc(var(--handleoffset) * -1);
  --togglehandleborder: 0 0;
  height: 1.5rem;
  width: 3rem;
  cursor: pointer;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  border-width: 1px;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  --tw-border-opacity: 0.2;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  --tw-bg-opacity: 0.5;
  border-radius: var(--rounded-badge, 1.9rem);
  transition: background,
    box-shadow var(--animation-input, 0.2s) ease-out;
  box-shadow: var(--handleoffsetcalculator) 0 0 2px var(--tglbg) inset,
    0 0 0 2px var(--tglbg) inset,
    var(--togglehandleborder);
}

.btm-nav > *.disabled,
    .btm-nav > *[disabled] {
  pointer-events: none;
  --tw-border-opacity: 0;
  background-color: hsl(var(--n) / var(--tw-bg-opacity));
  --tw-bg-opacity: 0.1;
  color: hsl(var(--bc) / var(--tw-text-opacity));
  --tw-text-opacity: 0.2;
}

.btn:active:hover,
  .btn:active:focus {
  animation: button-pop 0s ease-out;
  transform: scale(var(--btn-focus-scale, 0.97));
}

.btn:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
}

.btn.glass {
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
  outline-color: currentColor;
}

.btn.glass.btn-active {
  --glass-opacity: 25%;
  --glass-border-opacity: 15%;
}

.btn.btn-disabled,
  .btn[disabled],
  .btn:disabled {
  --tw-border-opacity: 0;
  background-color: hsl(var(--n) / var(--tw-bg-opacity));
  --tw-bg-opacity: 0.2;
  color: hsl(var(--bc) / var(--tw-text-opacity));
  --tw-text-opacity: 0.2;
}

.btn-group > input[type="radio"]:checked.btn,
  .btn-group > .btn-active {
  --tw-border-opacity: 1;
  border-color: hsl(var(--p) / var(--tw-border-opacity));
  --tw-bg-opacity: 1;
  background-color: hsl(var(--p) / var(--tw-bg-opacity));
  --tw-text-opacity: 1;
  color: hsl(var(--pc) / var(--tw-text-opacity));
}

.btn-group > input[type="radio"]:checked.btn:focus-visible, .btn-group > .btn-active:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-color: hsl(var(--p) / 1);
}

.btn:is(input[type="checkbox"]:checked),
.btn:is(input[type="radio"]:checked) {
  --tw-border-opacity: 1;
  border-color: hsl(var(--p) / var(--tw-border-opacity));
  --tw-bg-opacity: 1;
  background-color: hsl(var(--p) / var(--tw-bg-opacity));
  --tw-text-opacity: 1;
  color: hsl(var(--pc) / var(--tw-text-opacity));
}

.btn:is(input[type="checkbox"]:checked):focus-visible, .btn:is(input[type="radio"]:checked):focus-visible {
  outline-color: hsl(var(--p) / 1);
}

@keyframes button-pop {
  0% {
    transform: scale(var(--btn-focus-scale, 0.98));
  }

  40% {
    transform: scale(1.02);
  }

  100% {
    transform: scale(1);
  }
}

.checkbox:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: hsl(var(--bc) / 1);
}

.checkbox:checked,
  .checkbox[checked="true"],
  .checkbox[aria-checked="true"] {
  --tw-bg-opacity: 1;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  background-repeat: no-repeat;
  animation: checkmark var(--animation-input, 0.2s) ease-out;
  background-image: linear-gradient(-45deg, transparent 65%, hsl(var(--chkbg)) 65.99%),
      linear-gradient(45deg, transparent 75%, hsl(var(--chkbg)) 75.99%),
      linear-gradient(-45deg, hsl(var(--chkbg)) 40%, transparent 40.99%),
      linear-gradient(
        45deg,
        hsl(var(--chkbg)) 30%,
        hsl(var(--chkfg)) 30.99%,
        hsl(var(--chkfg)) 40%,
        transparent 40.99%
      ),
      linear-gradient(-45deg, hsl(var(--chkfg)) 50%, hsl(var(--chkbg)) 50.99%);
}

.checkbox:indeterminate {
  --tw-bg-opacity: 1;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  background-repeat: no-repeat;
  animation: checkmark var(--animation-input, 0.2s) ease-out;
  background-image: linear-gradient(90deg, transparent 80%, hsl(var(--chkbg)) 80%),
      linear-gradient(-90deg, transparent 80%, hsl(var(--chkbg)) 80%),
      linear-gradient(
        0deg,
        hsl(var(--chkbg)) 43%,
        hsl(var(--chkfg)) 43%,
        hsl(var(--chkfg)) 57%,
        hsl(var(--chkbg)) 57%
      );
}

.checkbox:disabled {
  cursor: not-allowed;
  border-color: transparent;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  opacity: 0.2;
}

@keyframes checkmark {
  0% {
    background-position-y: 5px;
  }

  50% {
    background-position-y: -2px;
  }

  100% {
    background-position-y: 0;
  }
}

[dir="rtl"] .checkbox:checked,
    [dir="rtl"] .checkbox[checked="true"],
    [dir="rtl"] .checkbox[aria-checked="true"] {
  background-image: linear-gradient(45deg, transparent 65%, hsl(var(--chkbg)) 65.99%),
        linear-gradient(-45deg, transparent 75%, hsl(var(--chkbg)) 75.99%),
        linear-gradient(45deg, hsl(var(--chkbg)) 40%, transparent 40.99%),
        linear-gradient(
          -45deg,
          hsl(var(--chkbg)) 30%,
          hsl(var(--chkfg)) 30.99%,
          hsl(var(--chkfg)) 40%,
          transparent 40.99%
        ),
        linear-gradient(45deg, hsl(var(--chkfg)) 50%, hsl(var(--chkbg)) 50.99%);
}

.input input:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.input[list]::-webkit-calendar-picker-indicator {
  line-height: 1em;
}

.input:focus,
  .input:focus-within {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: hsl(var(--bc) / 0.2);
}

.input-disabled,
  .input:disabled,
  .input[disabled] {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: hsl(var(--b2) / var(--tw-border-opacity));
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b2) / var(--tw-bg-opacity));
  --tw-text-opacity: 0.2;
}

.input-disabled::-moz-placeholder, .input:disabled::-moz-placeholder, .input[disabled]::-moz-placeholder {
  color: hsl(var(--bc) / var(--tw-placeholder-opacity));
  --tw-placeholder-opacity: 0.2;
}

.input-disabled::placeholder,
  .input:disabled::placeholder,
  .input[disabled]::placeholder {
  color: hsl(var(--bc) / var(--tw-placeholder-opacity));
  --tw-placeholder-opacity: 0.2;
}

.join > :where(*:not(:first-child)) {
  margin-top: 0px;
  margin-bottom: 0px;
  margin-left: -1px;
}

.link:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.link:focus-visible {
  outline: 2px solid currentColor;
  outline-offset: 2px;
}

:where(.menu li:not(.menu-title):not(.disabled) > *:not(ul):not(details):not(.menu-title)):not(summary):not(.active).focus,
  :where(.menu li:not(.menu-title):not(.disabled) > *:not(ul):not(details):not(.menu-title)):not(summary):not(.active):focus,
  :where(.menu li:not(.menu-title):not(.disabled) > *:not(ul):not(details):not(.menu-title)):is(summary):not(.active):focus-visible,
  :where(.menu li:not(.menu-title):not(.disabled) > details > summary:not(.menu-title)):not(summary):not(.active).focus,
  :where(.menu li:not(.menu-title):not(.disabled) > details > summary:not(.menu-title)):not(summary):not(.active):focus,
  :where(.menu li:not(.menu-title):not(.disabled) > details > summary:not(.menu-title)):is(summary):not(.active):focus-visible {
  cursor: pointer;
  background-color: hsl(var(--bc) / 0.1);
  --tw-text-opacity: 1;
  color: hsl(var(--bc) / var(--tw-text-opacity));
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.mockup-browser .mockup-browser-toolbar .input {
  position: relative;
  margin-left: auto;
  margin-right: auto;
  display: block;
  height: 1.75rem;
  width: 24rem;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b2) / var(--tw-bg-opacity));
  padding-left: 2rem;
}

.mockup-browser .mockup-browser-toolbar .input:before {
  content: "";
  position: absolute;
  left: 0.5rem;
  top: 50%;
  aspect-ratio: 1 / 1;
  height: 0.75rem;
  --tw-translate-y: -50%;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  border-radius: 9999px;
  border-width: 2px;
  border-color: currentColor;
  opacity: 0.6;
}

.mockup-browser .mockup-browser-toolbar .input:after {
  content: "";
  position: absolute;
  left: 1.25rem;
  top: 50%;
  height: 0.5rem;
  --tw-translate-y: 25%;
  --tw-rotate: -45deg;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  border-radius: 9999px;
  border-width: 1px;
  border-color: currentColor;
  opacity: 0.6;
}

@keyframes modal-pop {
  0% {
    opacity: 0;
  }
}

.progress::-moz-progress-bar {
  --tw-bg-opacity: 1;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  border-radius: var(--rounded-box, 1rem);
}

.progress:indeterminate {
  --progress-color: hsl(var(--bc));
  background-image: repeating-linear-gradient(
    90deg,
    var(--progress-color) -1%,
    var(--progress-color) 10%,
    transparent 10%,
    transparent 90%
  );
  background-size: 200%;
  background-position-x: 15%;
  animation: progress-loading 5s ease-in-out infinite;
}

.progress::-webkit-progress-bar {
  background-color: transparent;
  border-radius: var(--rounded-box, 1rem);
}

.progress::-webkit-progress-value {
  --tw-bg-opacity: 1;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  border-radius: var(--rounded-box, 1rem);
}

.progress:indeterminate::-moz-progress-bar {
  background-color: transparent;
  background-image: repeating-linear-gradient(
    90deg,
    var(--progress-color) -1%,
    var(--progress-color) 10%,
    transparent 10%,
    transparent 90%
  );
  background-size: 200%;
  background-position-x: 15%;
  animation: progress-loading 5s ease-in-out infinite;
}

@keyframes progress-loading {
  50% {
    background-position-x: -115%;
  }
}

.radio:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: hsl(var(--bc) / 1);
}

.radio:checked,
  .radio[aria-checked="true"] {
  --tw-bg-opacity: 1;
  background-color: hsl(var(--bc) / var(--tw-bg-opacity));
  animation: radiomark var(--animation-input, 0.2s) ease-out;
  box-shadow: 0 0 0 4px hsl(var(--b1)) inset,
      0 0 0 4px hsl(var(--b1)) inset;
}

.radio:disabled {
  cursor: not-allowed;
  opacity: 0.2;
}

@keyframes radiomark {
  0% {
    box-shadow: 0 0 0 12px hsl(var(--b1)) inset,
      0 0 0 12px hsl(var(--b1)) inset;
  }

  50% {
    box-shadow: 0 0 0 3px hsl(var(--b1)) inset,
      0 0 0 3px hsl(var(--b1)) inset;
  }

  100% {
    box-shadow: 0 0 0 4px hsl(var(--b1)) inset,
      0 0 0 4px hsl(var(--b1)) inset;
  }
}

@keyframes rating-pop {
  0% {
    transform: translateY(-0.125em);
  }

  40% {
    transform: translateY(-0.125em);
  }

  100% {
    transform: translateY(0);
  }
}

.select:focus {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: hsl(var(--bc) / 0.2);
}

.select-disabled,
  .select:disabled,
  .select[disabled] {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: hsl(var(--b2) / var(--tw-border-opacity));
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b2) / var(--tw-bg-opacity));
  --tw-text-opacity: 0.2;
}

.select-disabled::-moz-placeholder, .select:disabled::-moz-placeholder, .select[disabled]::-moz-placeholder {
  color: hsl(var(--bc) / var(--tw-placeholder-opacity));
  --tw-placeholder-opacity: 0.2;
}

.select-disabled::placeholder,
  .select:disabled::placeholder,
  .select[disabled]::placeholder {
  color: hsl(var(--bc) / var(--tw-placeholder-opacity));
  --tw-placeholder-opacity: 0.2;
}

.select-multiple,
  .select[multiple],
  .select[size].select:not([size="1"]) {
  background-image: none;
  padding-right: 1rem;
}

[dir="rtl"] .select {
  background-position: calc(0% + 12px) calc(1px + 50%),
    calc(0% + 16px) calc(1px + 50%);
}

.table :where(th, td) {
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
  vertical-align: middle;
}

.table tr.active,
  .table tr.active:nth-child(even),
  .table-zebra tbody tr:nth-child(even) {
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b2) / var(--tw-bg-opacity));
}

.table :where(thead, tbody) :where(tr:not(:last-child)),
    .table :where(thead, tbody) :where(tr:first-child:last-child) {
  border-bottom-width: 1px;
  --tw-border-opacity: 1;
  border-bottom-color: hsl(var(--b2) / var(--tw-border-opacity));
}

.table :where(thead, tfoot) {
  white-space: nowrap;
  font-size: 0.75rem;
  line-height: 1rem;
  font-weight: 700;
  color: hsl(var(--bc) / 0.6);
}

.textarea:focus {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: hsl(var(--bc) / 0.2);
}

.textarea-disabled,
  .textarea:disabled,
  .textarea[disabled] {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: hsl(var(--b2) / var(--tw-border-opacity));
  --tw-bg-opacity: 1;
  background-color: hsl(var(--b2) / var(--tw-bg-opacity));
  --tw-text-opacity: 0.2;
}

.textarea-disabled::-moz-placeholder, .textarea:disabled::-moz-placeholder, .textarea[disabled]::-moz-placeholder {
  color: hsl(var(--bc) / var(--tw-placeholder-opacity));
  --tw-placeholder-opacity: 0.2;
}

.textarea-disabled::placeholder,
  .textarea:disabled::placeholder,
  .textarea[disabled]::placeholder {
  color: hsl(var(--bc) / var(--tw-placeholder-opacity));
  --tw-placeholder-opacity: 0.2;
}

@keyframes toast-pop {
  0% {
    transform: scale(0.9);
    opacity: 0;
  }

  100% {
    transform: scale(1);
    opacity: 1;
  }
}

[dir="rtl"] .toggle {
  --handleoffsetcalculator: calc(var(--handleoffset) * 1);
}

.toggle:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: hsl(var(--bc) / 0.2);
}

.toggle:checked,
  .toggle[checked="true"],
  .toggle[aria-checked="true"] {
  --handleoffsetcalculator: var(--handleoffset);
  --tw-border-opacity: 1;
  --tw-bg-opacity: 1;
}

[dir="rtl"] .toggle:checked, [dir="rtl"] .toggle[checked="true"], [dir="rtl"] .toggle[aria-checked="true"] {
  --handleoffsetcalculator: calc(var(--handleoffset) * -1);
}

.toggle:indeterminate {
  --tw-border-opacity: 1;
  --tw-bg-opacity: 1;
  box-shadow: calc(var(--handleoffset) / 2) 0 0 2px var(--tglbg) inset,
      calc(var(--handleoffset) / -2) 0 0 2px var(--tglbg) inset,
      0 0 0 2px var(--tglbg) inset;
}

[dir="rtl"] .toggle:indeterminate {
  box-shadow: calc(var(--handleoffset) / 2) 0 0 2px var(--tglbg) inset,
        calc(var(--handleoffset) / -2) 0 0 2px var(--tglbg) inset,
        0 0 0 2px var(--tglbg) inset;
}

.toggle:disabled {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: hsl(var(--bc) / var(--tw-border-opacity));
  background-color: transparent;
  opacity: 0.3;
  --togglehandleborder: 0 0 0 3px hsl(var(--bc)) inset,
      var(--handleoffsetcalculator) 0 0 3px hsl(var(--bc)) inset;
}

.join.join-vertical {
  flex-direction: column;
}

.join.join-vertical .join-item:first-child:not(:last-child),
  .join.join-vertical *:first-child:not(:last-child) .join-item {
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
  border-top-left-radius: inherit;
  border-top-right-radius: inherit;
}

.join.join-vertical .join-item:last-child:not(:first-child),
  .join.join-vertical *:last-child:not(:first-child) .join-item {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
  border-bottom-left-radius: inherit;
  border-bottom-right-radius: inherit;
}

.join.join-horizontal {
  flex-direction: row;
}

.join.join-horizontal .join-item:first-child:not(:last-child),
  .join.join-horizontal *:first-child:not(:last-child) .join-item {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0;
  border-bottom-left-radius: inherit;
  border-top-left-radius: inherit;
}

.join.join-horizontal .join-item:last-child:not(:first-child),
  .join.join-horizontal *:last-child:not(:first-child) .join-item {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
  border-bottom-right-radius: inherit;
  border-top-right-radius: inherit;
}

.btn-group .btn:not(:first-child):not(:last-child) {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}

.btn-group .btn:first-child:not(:last-child) {
  margin-left: -1px;
  margin-top: -0px;
  border-top-left-radius: var(--rounded-btn, 0.5rem);
  border-top-right-radius: 0;
  border-bottom-left-radius: var(--rounded-btn, 0.5rem);
  border-bottom-right-radius: 0;
}

.btn-group .btn:last-child:not(:first-child) {
  border-top-left-radius: 0;
  border-top-right-radius: var(--rounded-btn, 0.5rem);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: var(--rounded-btn, 0.5rem);
}

.btn-group-horizontal .btn:not(:first-child):not(:last-child) {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}

.btn-group-horizontal .btn:first-child:not(:last-child) {
  margin-left: -1px;
  margin-top: -0px;
  border-top-left-radius: var(--rounded-btn, 0.5rem);
  border-top-right-radius: 0;
  border-bottom-left-radius: var(--rounded-btn, 0.5rem);
  border-bottom-right-radius: 0;
}

.btn-group-horizontal .btn:last-child:not(:first-child) {
  border-top-left-radius: 0;
  border-top-right-radius: var(--rounded-btn, 0.5rem);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: var(--rounded-btn, 0.5rem);
}

.btn-group-vertical .btn:first-child:not(:last-child) {
  margin-left: -0px;
  margin-top: -1px;
  border-top-left-radius: var(--rounded-btn, 0.5rem);
  border-top-right-radius: var(--rounded-btn, 0.5rem);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}

.btn-group-vertical .btn:last-child:not(:first-child) {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
  border-bottom-left-radius: var(--rounded-btn, 0.5rem);
  border-bottom-right-radius: var(--rounded-btn, 0.5rem);
}

.join.join-vertical > :where(*:not(:first-child)) {
  margin-left: 0px;
  margin-right: 0px;
  margin-top: -1px;
}

.join.join-horizontal > :where(*:not(:first-child)) {
  margin-top: 0px;
  margin-bottom: 0px;
  margin-left: -1px;
}

.mx-4 {
  margin-left: 1rem;
  margin-right: 1rem;
}

.mx-5 {
  margin-left: 1.25rem;
  margin-right: 1.25rem;
}

.mb-2 {
  margin-bottom: 0.5rem;
}

.mb-4 {
  margin-bottom: 1rem;
}

.block {
  display: block;
}

.flex {
  display: flex;
}

.table {
  display: table;
}

.h-screen {
  height: 100vh;
}

.w-64 {
  width: 16rem;
}

.w-full {
  width: 100%;
}

.flex-col {
  flex-direction: column;
}

.items-center {
  align-items: center;
}

.justify-start {
  justify-content: flex-start;
}

.justify-center {
  justify-content: center;
}

.space-x-0 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-x-reverse: 0;
  margin-right: calc(0px * var(--tw-space-x-reverse));
  margin-left: calc(0px * calc(1 - var(--tw-space-x-reverse)));
}

.rounded-lg {
  border-radius: 0.5rem;
}

.border {
  border-width: 1px;
}

.border-gray-400 {
  --tw-border-opacity: 1;
  border-color: rgb(156 163 175 / var(--tw-border-opacity));
}

.bg-blue-500 {
  --tw-bg-opacity: 1;
  background-color: rgb(59 130 246 / var(--tw-bg-opacity));
}

.px-4 {
  padding-left: 1rem;
  padding-right: 1rem;
}

.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.text-3xl {
  font-size: 1.875rem;
  line-height: 2.25rem;
}

.text-xl {
  font-size: 1.25rem;
  line-height: 1.75rem;
}

.font-bold {
  font-weight: 700;
}

.font-semibold {
  font-weight: 600;
}

.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.filter {
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.transition {
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.\[a-zA-Z\:\\-\\\.\] {
  a-z-a--z: \-\.;
}

.hover\:bg-blue-700:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(29 78 216 / var(--tw-bg-opacity));
}