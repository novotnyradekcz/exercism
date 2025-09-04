// @ts-check

/**
 * Implement the classes etc. that are needed to solve the
 * exercise in this file. Do not forget to export the entities
 * you defined so they are available for the tests.
 */

export function Size(width = 80, height = 60) {
  this.width = width;
  this.height = height;
}

Size.prototype.resize = function (newWidth, newHeight) {
  this.width = newWidth;
  this.height = newHeight;
}

export function Position(x = 0, y = 0) {
  this.x = x;
  this.y = y;
}

Position.prototype.move = function (newX, newY) {
  this.x = newX;
  this.y = newY;
}

export class ProgramWindow {
  constructor() {
    this._screenSize = new Size(800, 600);
    this.size = new Size();
    this.position = new Position();
  }

  get screenSize() {
    return this._screenSize;
  }

  move(newPosition) {
    if (newPosition.x < 0) {
      newPosition.x = 0;
    }
    newPosition.x = Math.min(newPosition.x, this.screenSize.width - this.size.width);
    if (newPosition.y < 0) {
      newPosition.y = 0;
    }
    newPosition.y = Math.min(newPosition.y, this.screenSize.height - this.size.height);
    this.position = newPosition;
  }

  resize(newSize) {
    if (newSize.width < 1) {
      newSize.width = 1;
    }
    newSize.width = Math.min(newSize.width, this.screenSize.width - this.position.x);
    if (newSize.height < 1) {
      newSize.height = 1;
    }
    newSize.height = Math.min(newSize.height, this.screenSize.height - this.position.y);
    this.size = newSize;
  }
}

export function changeWindow(window) {
    window.move(new Position(100, 150));
    window.resize(new Size(400, 300));
    return window;
  }
